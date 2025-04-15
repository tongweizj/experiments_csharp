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
        // 数据库入口
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
            private set => SetProperty(ref _isLoading, value);
        }
        
        // basket 下拉菜单数据
        private ObservableCollection<BasketViewModel> _baskets = new ObservableCollection<BasketViewModel>();
        public ObservableCollection<BasketViewModel> Baskets
        {
            get => _baskets;
            private set => SetProperty(ref _baskets, value);
        }

        // basketItems 数据
        // 全量数据
        public ObservableCollection<BasketItemViewModel> _basketItems = new ObservableCollection<BasketItemViewModel>();
        public ObservableCollection<BasketItemViewModel> BasketItems
        {
            get => _basketItems;
            private set => SetProperty(ref _basketItems, value);
        }

        // DataGrid显示数据（经过筛选）
        public ObservableCollection<BasketItemViewModel> _filterBasketItems = new ObservableCollection<BasketItemViewModel>();
        
        /// <summary>
        /// 当前显示的购物篮商品数据（根据选中购物篮筛选）
        /// </summary>
        public ObservableCollection<BasketItemViewModel> FilterBasketItems
        {
            get => _filterBasketItems;
            private set => SetProperty(ref _filterBasketItems, value);
        }

        /// <summary>
        /// 当前最大购物篮商品ID（用于新增商品时生成ID）
        /// </summary>
        private int _maxBasketItemID;
        public int MaxBasketItemId
        {
            get => _maxBasketItemID;
            private set => SetProperty(ref _maxBasketItemID, value);
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
                if (SetProperty(ref _selectedBasket, value))
                {
                    UpdateFilterBasketItems();
                }//更新选择的basket后，更新 DataGrid数据
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

        public void SetMaxBasketItemId(int newId)
        {
            _maxBasketItemID = newId;
            RaisePropertyChanged(nameof(MaxBasketItemId));
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
                // 从数据提供者（_dataProvider）异步获取购物篮数据
                // GetBasketDataAsync 可能是访问数据库或 Web API，因此使用 await 等待异步结果
                var baskets = await _dataProvider.GetBasketDataAsync();

                // 将获取到的原始 basket 数据集合转换为 ViewModel 对象集合
                // 用于与界面（UI）进行绑定（MVVM模式中的常规做法）
                // Select() 是 LINQ 中的投影方法，逐个转换为 BasketViewModel 实例
                var tempCollection = new ObservableCollection<BasketViewModel>(
                    baskets.Select(b => new BasketViewModel(b)));

                // 在 UI 线程上更新绑定的 Baskets 属性
                // WPF 中，UI 控件只能由 UI 线程操作，不能从后台线程直接修改绑定集合
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
                // 声明并初始化一个名为 maxId 的整数变量
                // 如果 items 集合中有元素，则取出所有元素中最大的 IdBasketItem 值作为 maxId；
                // 否则（即集合为空），maxId 设置为 0
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
            // 如果当前没有选中的购物篮（例如界面还没加载好或用户没选）
            if (SelectedBasket == null)
            {
                // 清空之前筛选的商品列表
                FilterBasketItems.Clear();// 清空筛选结果
                return;
            }
            // 筛选当前购物篮的商品
            var filtered = BasketItems
                // 只保留那些非 null 且 IdBasket 等于选中购物篮 Id 的商品
                .Where(item => item != null && item.IdBasket == SelectedBasket.IdBasket)
                .ToList();
            // 判断当前筛选结果与已有的 FilterBasketItems 是否相同
            // 如果不同，就更新集合，触发 UI 的刷新
            if (!filtered.SequenceEqual(FilterBasketItems))
            {
                // 创建新的 ObservableCollection，并赋值给绑定属性
                // 这样 UI（如 ListBox 或 DataGrid）会自动更新显示的内容
                FilterBasketItems = new ObservableCollection<BasketItemViewModel>(filtered);
            }
        }
        #endregion
    }
}
