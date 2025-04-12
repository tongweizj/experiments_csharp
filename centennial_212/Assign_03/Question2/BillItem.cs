using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class BillItem: INotifyPropertyChanged
    {
        private bool _isSelected;
        private decimal _price;
        private int _quantity;
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
        }
        public string Name { get; set; }
        public decimal Price {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(Subtotal)); // Ensure UI updates when price changes
            }
        }
        public int Quantity { get => _quantity; set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
                OnPropertyChanged(nameof(Subtotal)); // Ensure UI updates when quantity changes
            } }

        // Calculated property
        public decimal Subtotal => Price * Quantity;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
