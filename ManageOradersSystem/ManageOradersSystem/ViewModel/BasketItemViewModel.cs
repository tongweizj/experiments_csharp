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
        private readonly BasketItem _model;
        public BasketItemViewModel(BasketItem model)
        {
            _model = model;
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
