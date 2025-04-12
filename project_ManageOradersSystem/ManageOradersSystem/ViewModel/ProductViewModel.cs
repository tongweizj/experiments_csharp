using ManageOradersSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOSLibrary.Models;

namespace ManageOradersSystem.ViewModel
{
    class ProductViewModel:ViewModelBase
    {
        private readonly Product _model;
        public ProductViewModel(Product model)
        {
            _model = model;
        }

        public short IdProduct
        {
            get => _model.IdProduct;
            set
            {
                _model.IdProduct = value;
                RaisePropertyChanged();
            }
        }

        public string? ProductName
        {
            get => _model.ProductName;
            set
            {
                _model.ProductName = value;
                RaisePropertyChanged();
            }
        }

        public string? Description
        {
            get => _model.Description;
            set
            {
                _model.Description = value;
                RaisePropertyChanged();
            }
        }

        public decimal? Price
        {
            get => _model.Price;
            set
            {
                _model.Price = value;
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
    }
}
