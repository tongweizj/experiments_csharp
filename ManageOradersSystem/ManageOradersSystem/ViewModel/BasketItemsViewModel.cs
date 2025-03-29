//using ManageOradersSystem.Model;
//using ManageOradersSystem.Models;
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Data;

//namespace ManageOradersSystem.ViewModel
//{
//    class BasketItemsViewModel : ViewModelBase
//    { }
//    //{
//        //private BasketItemViewModel? _selectedBasketItem;

//        //public ObservableCollection<BasketItemViewModel> _basketItems;
//        //public ObservableCollection<BasketItemViewModel> basketItems 
//        //{ 
//        //    get=>_basketItems;
//        //    set
//        //    {
//        //        _basketItems = value;
//        //    }
//        //}

//        //private ICollectionView _filteredItemsView;
//        //public ICollectionView FilteredItemsView
//        //{
//        //    get
//        //    {
//        //        if (_filteredItemsView == null)
//        //        {
//        //            _filteredItemsView = CollectionViewSource.GetDefaultView(basketItems);
//        //            _filteredItemsView.Filter = item =>
//        //                !SelectedBasketId.HasValue ||
//        //                ((BasketItemViewModel)item).IdBasket == SelectedBasketId;
//        //        }
//        //        return _filteredItemsView;
//        //    }
//        //}

//        //public BasketItemsViewModel()
//        //{
//        //    // 构造器
//        //    //  获取原始学生数据（可能是数据库、API 或本地文件）
//        //    var rawData = DataProvider.GetBasketItemData();
//        //    if (rawData is not null)
//        //    {
//        //        foreach (var basketItem in rawData)
//        //        {
//        //            // 将原始数据 Student 转换为 StudentItemViewModel，并添加到集合中。
//        //            basketItems.Add(new BasketItemViewModel(basketItem));
//        //        }
//        //    }
//        //    _filteredItemsView = null;
//        //}

//        //// combox 下拉菜单选择后，跟新
//        //public BasketItemViewModel? SelectedBaskeItem
//        //{
//        //    get => _selectedBasketItem;
//        //    set
//        //    {
//        //        _selectedBasketItem = value;
//        //        RaisePropertyChanged();
//        //    }
//        //}


//        //private int? _selectedBasketId;
//        //public int? SelectedBasketId
//        //{
//        //    get => _selectedBasketId;
//        //    set
//        //    {
//        //        _selectedBasketId = value;
//        //        RaisePropertyChanged();
//        //        FilteredItemsView.Refresh(); // 刷新过滤视图
//        //    }
//        //}
//        // 动态过滤的集合
//    //    public ObservableCollection<BasketItemViewModel> FilteredItems =>
//    //        SelectedBasketId.HasValue
//    //            ? new ObservableCollection<BasketItemViewModel>(
//    //                basketItems.Where(item => item?.IdBasket == SelectedBasketId)
//    //              )
//    //            : basketItems; // 未选择时返回全部
//    //}
//}
