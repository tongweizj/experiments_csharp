using ManageOradersSystem.Model;
using ManageOradersSystem.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOradersSystem.ViewModel
{
    class MainWindowViewMode: ViewModelBase
    {
        // 单例实现
        private static readonly Lazy<MainWindowViewMode> _instance =
            new Lazy<MainWindowViewMode>(() => new MainWindowViewMode());
        public static MainWindowViewMode Instance => _instance.Value;

        // basketItems 数据
        // 全量数据
        public ObservableCollection<BasketItemViewModel> _basketItems = new ObservableCollection<BasketItemViewModel>();
        public ObservableCollection<BasketItemViewModel> basketItems
        {
            get => _basketItems;
            set
            {
                _basketItems = value;
                RaisePropertyChanged();
            }
        }
        // data
        private int _maxBasketItemID;
        public int maxBasketItemID
        {
            get => _maxBasketItemID;
            set
            {
                _maxBasketItemID = value;
                RaisePropertyChanged();
            }
        }
        // data grid 的显示数据
        public ObservableCollection<BasketItemViewModel> _filterBasketItems = new ObservableCollection<BasketItemViewModel>();
        public ObservableCollection<BasketItemViewModel> filterBasketItems
        {
            get => _filterBasketItems;
            set
            {
                _filterBasketItems = value;
                RaisePropertyChanged();
            }
        }
        // 构造器
        private MainWindowViewMode()
        {
            //  获取数据库获取原始baskets数据
            getBasketData();
            getBasketItemData();
            // 重置data grid里的数据
            _selectedBasket = null;
            //_maxBasketItemID = 0;
        }

        // basket 下拉菜单数据
        private ObservableCollection<BasketViewModel> _baskets;
        public ObservableCollection<BasketViewModel> baskets
        {
            get => _baskets;
            set
            {
                _baskets = value;
                RaisePropertyChanged();
            }
        }
        private BasketViewModel? _selectedBasket;
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

        public void getBasketData()
        {
            var rawData = DataProvider.GetBasketData();
            if (rawData is not null)
            {
                baskets = new();
                foreach (var basket in rawData)
                {
                    // 将原始数据 basket 转换为 BasketItemViewModel，并添加到集合中。
                    baskets.Add(new BasketViewModel(basket));
                }
            }

            RaisePropertyChanged();

        }
        public void getBasketItemData()
        {
            var rawBasketItemsData = DataProvider.GetBasketItemData();
            if (rawBasketItemsData is not null)
            {

                // 清空现有集合而不是创建新实例，以保持绑定
                _basketItems.Clear();
                foreach (var basketItem in rawBasketItemsData)
                {

                    var itemVm = new BasketItemViewModel(basketItem);
                    _basketItems.Add(itemVm);
                    if (basketItem.IdBasketItem > _maxBasketItemID)
                    {
                        _maxBasketItemID = basketItem.IdBasketItem;
                    }
                }
            }
            // 更新筛选结果
            UpdateFilterBasketItems();
            RaisePropertyChanged(nameof(basketItems));
            RaisePropertyChanged(nameof(maxBasketItemID));
            RaisePropertyChanged();

        }
        public void UpdateFilterBasketItems()
        {

            if (SelectedBasket == null)
            {
                //filterBasketItems = new ObservableCollection<BasketItemViewModel>();
                return;
            }

            // 使用当前内存中的 basketItems 进行筛选
            var filteredItems = basketItems
                .Where(item => item != null && item.IdBasket == SelectedBasket.IdBasket)
                .ToList();

            // 只有当筛选结果不同时才更新
            if (!filteredItems.SequenceEqual(filterBasketItems))
            {
                filterBasketItems = new ObservableCollection<BasketItemViewModel>(filteredItems);
                RaisePropertyChanged(nameof(filterBasketItems));
            }

        }
    }
}
