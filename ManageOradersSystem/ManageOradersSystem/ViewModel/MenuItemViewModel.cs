using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageOradersSystem.Models;

namespace ManageOradersSystem.ViewModel
{
    public class MenuItemViewModel: ViewModelBase
    {
        private readonly Menu _model;
        public MenuItemViewModel(Menu model)
        {
            _model = model;
        }


        //public int Id => _model.Id;

        public string? Category
        {
            get => _model.Category;
            set
            {
                _model.Category = value;
                RaisePropertyChanged();
            }
        }

        public string? Name
        {
            get => _model.Name;
            set
            {
                _model.Name = value;
                RaisePropertyChanged();
            }
        }

        public decimal Price
        {
            get => _model.Price;
            set
            {
                _model.Price = value;
                RaisePropertyChanged();
            }
        }
    }
}
