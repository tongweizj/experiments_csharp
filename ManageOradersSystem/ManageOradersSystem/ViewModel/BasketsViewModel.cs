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
    class BasketsViewModel: ViewModelBase
    {
        // basket 下拉菜单数据
        public ObservableCollection<BasketViewModel> baskets { get; } = new();
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
        public BasketsViewModel()
        {
            //  获取数据库获取原始baskets数据
            var rawData = DataProvider.GetBasketData();
            if (rawData is not null)
            {
                foreach (var basket in rawData)
                {
                    // 将原始数据 basket 转换为 BasketItemViewModel，并添加到集合中。
                    baskets.Add(new BasketViewModel(basket));
                }
            }
            // 重置data grid里的数据
            _selectedBasket = null;
            var rawBasketItemsData = DataProvider.GetBasketItemData();
            if (rawBasketItemsData is not null)
            {
                foreach (var basketItem in rawBasketItemsData)
                {
                    // 将原始数据 Student 转换为 StudentItemViewModel，并添加到集合中。
                    basketItems.Add(new BasketItemViewModel(basketItem));
                }
            }
        }

        public void UpdateFilterBasketItems()
        {
            if (SelectedBasket == null)
            {
                _basketItems = new ObservableCollection<BasketItemViewModel>();
                return;
            }
            filterBasketItems = new ObservableCollection<BasketItemViewModel>(
                   basketItems.Where(item => item?.IdBasket == SelectedBasket.IdBasket)
            );
        }
    }

        // 创建一个默认学生对象（Student）
        // 包装为 StudentItemViewModel
        // 添加到集合（自动触发 UI 更新）
        // 设置为当前选中项（触发 SelectedStudent 变更通知）。
        //internal void Add()
        //{
        //    var basket = new Basket { IdBasket = "New", IdShopper = "New", Quantity = , SubTotal= 0.0M };
        //    var viewModel = new BasketViewModel(basket);
        //    baskets.Add(viewModel);
        //    SelectedBasket = viewModel;
        //}
    
}
