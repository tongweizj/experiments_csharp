using ManageOradersSystem.Model;
using ManageOradersSystem.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOSLibrary.Models;
using System.Windows;

namespace ManageOradersSystem.ViewModel
{
    class AddNewItemViewModel: ViewModelBase
    {
        #region 私有字段
        private readonly MainWindowViewMode _mainWindowViewModel;
        private readonly IDataProvider _dataProvider;
        #endregion
        #region 属性
        private BasketViewModel _selectedBasket;
        public BasketViewModel SelectedBasket
        {
            get => _selectedBasket;
            set => SetProperty(ref _selectedBasket, value);
        }

        public ObservableCollection<ProductViewModel> Products { get; } = new ObservableCollection<ProductViewModel>();

        private ProductViewModel _selectedProduct;
        public ProductViewModel SelectedProduct
        {
            get => _selectedProduct;
            set => SetProperty(ref _selectedProduct, value);
        }

        private byte _quantity = 1;
        public byte Quantity
        {
            get => _quantity;

            set => SetProperty(ref _quantity, value);
        }
        #endregion
        #region 构造函数
        public AddNewItemViewModel()
        {
            _mainWindowViewModel = MainWindowViewMode.Instance;
            _dataProvider = new DataProvider(new OmsContext());

            // 异步初始化产品数据
            _ = InitializeProductsAsync();
        }
        #endregion


        #region 公共方法
        public async Task InitializeProductsAsync()
        {
            try
            {
                var products = await _dataProvider.GetProductDataAsync();
                Products.Clear();

                foreach (var product in products)
                {
                    Products.Add(new ProductViewModel(product));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载产品数据失败: {ex.Message}");
            }
        }

        public async Task<bool> UpdateBasketAsync()
        {
            if (SelectedBasket == null || SelectedProduct == null || Quantity <= 0)
            {
                MessageBox.Show("请选择购物篮、产品和有效数量");
                return false;
            }

            try
            {
                // 创建新的BasketItem
                var newBasketItemId = _mainWindowViewModel.MaxBasketItemId + 1;
                var newBasketItem = new NewBasketItem
                {
                    IdBasketItem = newBasketItemId,
                    IdProduct = SelectedProduct.IdProduct,
                    Quantity = Quantity,
                    IdBasket = SelectedBasket.IdBasket
                };

                // 更新数据库
                using (var context = new OmsContext())
                {
                    // 添加新项
                    context.BasketItems.Add(new BasketItem
                    {
                        IdBasketItem = newBasketItem.IdBasketItem,
                        IdProduct = newBasketItem.IdProduct,
                        Quantity = newBasketItem.Quantity,
                        IdBasket = newBasketItem.IdBasket
                    });

                    // 更新购物篮汇总
                    var basket = await context.Baskets.FindAsync(SelectedBasket.IdBasket);
                    if (basket != null)
                    {
                        basket.Quantity += Quantity;
                        basket.SubTotal += SelectedProduct.Price * Quantity;
                    }

                    await context.SaveChangesAsync();
                }

                // 更新ViewModel
                _mainWindowViewModel.SetMaxBasketItemId(newBasketItemId);

                var newItemVm = new BasketItemViewModel(
                    newBasketItemId,
                    SelectedProduct.IdProduct,
                    SelectedProduct.ProductName,
                    SelectedProduct.Price,
                    Quantity,
                    SelectedBasket.IdBasket
                );

                _mainWindowViewModel.BasketItems.Add(newItemVm);
                await _mainWindowViewModel.InitializeAsync(); // 刷新数据

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新购物篮失败: {ex.Message}");
                return false;
            }
        }
        #endregion

    }
}
