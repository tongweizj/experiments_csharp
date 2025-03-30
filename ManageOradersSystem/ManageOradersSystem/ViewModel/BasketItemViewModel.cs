using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageOradersSystem.Models;

namespace ManageOradersSystem.ViewModel
{
    public class BasketItemViewModel: ViewModelBase
    {
        private readonly NewBasketItem _model;
        public BasketItemViewModel(NewBasketItem model)
        {
            _model = model;
        }

        // 新增便捷构造函数
        public BasketItemViewModel(int idBasketItem, short? idProduct, string nameProduct,
                                 decimal? priceProduct, byte? quantity, int? idBasket)
        {
            _model = new NewBasketItem
            {
                IdBasketItem = idBasketItem,
                IdProduct = idProduct,
                NameProduct = nameProduct,
                PriceProduct = priceProduct,
                Quantity = quantity,
                IdBasket = idBasket
            };
        }

        //public int Id => _model.Id;

        public int IdBasketItem
        {
            get => _model.IdBasketItem;
            set
            {
                _model.IdBasketItem = value;
                RaisePropertyChanged();
            }
        }

        public short? IdProduct
        {
            get => _model.IdProduct;
            set
            {
                _model.IdProduct = value;
                RaisePropertyChanged();
            }
        }
        public string? NameProduct
        {
            get => _model.NameProduct;
            set
            {
                _model.NameProduct = value;
                RaisePropertyChanged();
            }
        }

        public decimal? PriceProduct
        {
            get => _model.PriceProduct;
            set
            {
                _model.PriceProduct = value;
                RaisePropertyChanged();
            }
        }
        public byte? Quantity
        {
            get => _model.Quantity;
            set
            {
                _model.Quantity = value;
                RaisePropertyChanged();
            }
        }

        public int? IdBasket
        {
            get => _model.IdBasket;
            set
            {
                _model.IdBasket = value;
                RaisePropertyChanged();
            }
        }

        public Basket? IdBasketNavigation
        {
            get => _model.IdBasketNavigation;
            set
            {
                _model.IdBasketNavigation = value;
                RaisePropertyChanged();
            }
        }


        public Product? IdProductNavigation
        {
            get => _model.IdProductNavigation;
            set
            {
                _model.IdProductNavigation = value;
                RaisePropertyChanged();
            }
        }


    }
}
