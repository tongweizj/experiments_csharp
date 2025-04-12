using ManageOradersSystem.Model;
using ManageOradersSystem.Models;
using MOSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ManageOradersSystem.ViewModel
{
    /// <summary>
    /// 主窗口ViewModel
    /// 功能：管理订单系统的核心业务逻辑和数据
    /// </summary>
    class MainWindowViewMode : ViewModelBase
    {
        #region 单例实现
        // 使用Lazy<T>实现线程安全的单例模式
        private static readonly Lazy<MainWindowViewMode> _instance =
            new Lazy<MainWindowViewMode>(() => new MainWindowViewMode());

        /// <summary>
        /// 获取单例实例
        /// </summary>
        public static MainWindowViewMode Instance => _instance.Value;
        #endregion
        #region 私有字段和依赖
        private readonly IDataProvider _dataProvider;
        #endregion


        #region 数据属性
        private bool _isLoading;
        /// <summary>
        /// 是否正在加载数据
        /// </summary>
        public bool IsLoading
        {
            get => _isLoading;
            private set
            {
                _isLoading = value;
                RaisePropertyChanged();
            }
        }
        
        // basket 下拉菜单数据
        private ObservableCollection<BasketViewModel> _baskets = new ObservableCollection<BasketViewModel>();
        public ObservableCollection<BasketViewModel> Baskets
        {
            get => _baskets;
            set
            {
                _baskets = value;
                RaisePropertyChanged();
            }
        }

        // basketItems 数据
        // 全量数据
        public ObservableCollection<BasketItemViewModel> _basketItems = new ObservableCollection<BasketItemViewModel>();
        public ObservableCollection<BasketItemViewModel> BasketItems
        {
            get => _basketItems;
            set
            {
                _basketItems = value;
                RaisePropertyChanged();
            }
        }

        // DataGrid显示数据（经过筛选）
        public ObservableCollection<BasketItemViewModel> _filterBasketItems = new ObservableCollection<BasketItemViewModel>();
        
        /// <summary>
        /// 当前显示的购物篮商品数据（根据选中购物篮筛选）
        /// </summary>
        public ObservableCollection<BasketItemViewModel> FilterBasketItems
        {
            get => _filterBasketItems;
            set
            {
                _filterBasketItems = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// 当前最大购物篮商品ID（用于新增商品时生成ID）
        /// </summary>
        private int _maxBasketItemID;
        public int MaxBasketItemId
        {
            get => _maxBasketItemID;
            set
            {
                _maxBasketItemID = value;
                RaisePropertyChanged();
            }
        }


        private BasketViewModel? _selectedBasket;

        /// <summary>
        /// 当前选中的购物篮
        /// 设置时会自动触发筛选逻辑
        /// </summary>
        public BasketViewModel? SelectedBasket
        {
            get => _selectedBasket;
            set
            {
                _selectedBasket = value;
                RaisePropertyChanged();
                UpdateFilterBasketItems(); //更新选择的basket后，更新 DataGrid数据
            }
        }
        #endregion

        #region 构造函数

        /// <summary>
        /// 私有构造函数（单例模式）
        /// </summary>
        private MainWindowViewMode()
        {
            // 初始化数据访问对象
            _dataProvider = new DataProvider(new OmsContext());
        }
        #endregion

        #region 公共方法

        /// <summary>
        /// 异步初始化数据
        /// </summary>
        public async Task InitializeAsync()
        {
            IsLoading = true;
            try
            {
                // 并行加载数据
                var loadBasketsTask = LoadBasketsAsync();
                var loadBasketItemsTask = LoadBasketItemsAsync();
                await Task.WhenAll(loadBasketsTask, loadBasketItemsTask);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"初始化失败: {ex}");
                MessageBox.Show($"数据加载失败: {ex.Message}");
            }
            finally
            {
                IsLoading = false;
            }
        }
        #endregion

        #region 私有方法

        /// <summary>
        /// 异步加载购物篮数据
        /// </summary>
        private async Task LoadBasketsAsync()
        {
            try
            {
                var baskets = await _dataProvider.GetBasketDataAsync();
                var tempCollection = new ObservableCollection<BasketViewModel>(
                    baskets.Select(b => new BasketViewModel(b)));

                // 在UI线程更新集合
                await Application.Current.Dispatcher.InvokeAsync(() =>
                {
                    Baskets = tempCollection;
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"加载Baskets失败: {ex}");
                throw;
            }
        }

        /// <summary>
        /// 异步加载购物篮商品数据
        /// </summary>
        private async Task LoadBasketItemsAsync()
        {
            try
            {
                var items = await _dataProvider.GetBasketItemDataAsync();
                var tempCollection = new ObservableCollection<BasketItemViewModel>(
                    items.Select(i => new BasketItemViewModel(i)));

                // 计算最大ID
                int maxId = items.Any() ? items.Max(i => i.IdBasketItem) : 0;

                // 在UI线程更新集合
                await Application.Current.Dispatcher.InvokeAsync(() =>
                {
                    BasketItems = tempCollection;
                    MaxBasketItemId = maxId;
                    UpdateFilterBasketItems();
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"加载BasketItems失败: {ex}");
                throw;
            }
        }
        #endregion


        #region 数据过滤方法
        /// <summary>
        /// 根据选中的购物篮筛选商品数据
        /// </summary>
        private void UpdateFilterBasketItems()
        {
            if (SelectedBasket == null)
            {
                FilterBasketItems.Clear();// 清空筛选结果
                return;
            }
            // 筛选当前购物篮的商品
            var filtered = BasketItems
                .Where(item => item != null && item.IdBasket == SelectedBasket.IdBasket)
                .ToList();

            if (!filtered.SequenceEqual(FilterBasketItems))
            {
                FilterBasketItems = new ObservableCollection<BasketItemViewModel>(filtered);
            }
        }
        #endregion
    }
}
