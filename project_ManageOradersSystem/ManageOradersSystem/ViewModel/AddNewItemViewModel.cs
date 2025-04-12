using ManageOradersSystem.Model;
using ManageOradersSystem.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOSLibrary.Models;

namespace ManageOradersSystem.ViewModel
{
    class AddNewItemViewModel: ViewModelBase
    {
        private MainWindowViewMode _mainWindowViewMode;
        // basket 下拉菜单数据
        // 在controller 上直接使用DataGridViewModel
        private BasketViewModel? _selectedBasket;
        public BasketViewModel? SelectedBasket
        {
            get => _selectedBasket;
            set
            {
                _selectedBasket = value;
                RaisePropertyChanged();
            }
        }
        // Productsl 下拉菜单数据
        public ObservableCollection<ProductViewModel> products { get; } = new();
        private ProductViewModel? _selectedProduct;
        public ProductViewModel? SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                RaisePropertyChanged();
            }
        }

        // 构造器
        public AddNewItemViewModel()
        {
            _mainWindowViewMode = MainWindowViewMode.Instance;
            //  获取数据库获取原始b product数据
            var rawData = DataProvider.GetProductData();
            if (rawData is not null)
            {
                foreach (var product in rawData)
                {
                    // 将原始数据 basket 转换为 BasketItemViewModel，并添加到集合中。
                    products.Add(new ProductViewModel(product));
                }
            }
        }

        public void updateBasket(BasketViewModel basket, ProductViewModel product, byte quantity)
        {

            int maxBasketItemID = _mainWindowViewMode.maxBasketItemID;

            var newBasketItem = new BasketItem
            {
                IdBasketItem = maxBasketItemID + 1,
                IdProduct = product.IdProduct,
                Quantity = quantity,
                IdBasket = basket.IdBasket
            };

            using (var context = new OmsContext())
            {
                context.BasketItems.Add(newBasketItem);
                context.SaveChanges();

                var existingBasket = context.Baskets.Find(basket.IdBasket);
                if (existingBasket != null)
                {
                    existingBasket.Quantity = (byte)(existingBasket.Quantity + quantity);
                    existingBasket.SubTotal += product.Price * quantity;
                    context.SaveChanges();
                }
            }
            // 更新最大ID
            _mainWindowViewMode.maxBasketItemID = maxBasketItemID + 1;

            // 创建新的 ViewModel 项并添加到集合

            var newBasketItemVm = new BasketItemViewModel(
                 maxBasketItemID + 1,
                 product.IdProduct,
                 product.ProductName,
                 product.Price,
                 quantity,
                 basket.IdBasket
             );

            // 直接添加到内存集合
            _mainWindowViewMode.basketItems.Add(newBasketItemVm);
            _mainWindowViewMode.getBasketData();
            _mainWindowViewMode.getBasketItemData();
        }
    }
}
