using ManageOradersSystem.Models;
using MOSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOradersSystem.ViewModel
{
    class BasketViewModel: ViewModelBase
    {
        private readonly NewBasket _model;
        public BasketViewModel(NewBasket model)
        {
            _model = model;
        }


        //public int Id => _model.Id;

        public int IdBasket
        {
            get => _model.IdBasket;
            set
            {
                _model.IdBasket = value;
                RaisePropertyChanged();
            }
        }

        public int? IdShopper
        {
            get => _model.IdShopper;
            set
            {
                _model.IdShopper = value;
                RaisePropertyChanged();
            }
        }
        public string? NameShopper
        {
            get => _model.NameShopper;
            set
            {
                _model.NameShopper = value;
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

        public decimal? SubTotal
        {
            get => _model.SubTotal;
            set
            {
                _model.SubTotal = value;
                RaisePropertyChanged();
            }
        }

        public DateTime OrderDate
        {
            get => _model.OrderDate;
            set
            {
                _model.OrderDate = value;
                RaisePropertyChanged();
            }
        }

        public ICollection<BasketItem> BasketItems
        {
            get => _model.BasketItems;
            set
            {
                _model.BasketItems = value;
                RaisePropertyChanged();
            }
        }

        public Shopper? IdShopperNavigation
        {
            get => _model.IdShopperNavigation;
            set
            {
                _model.IdShopperNavigation = value;
                RaisePropertyChanged();
            }
        }
    }
}
