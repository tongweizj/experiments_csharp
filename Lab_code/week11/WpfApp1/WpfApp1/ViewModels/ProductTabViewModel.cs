using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1.ViewModels
{
    // ProductTabViewModel.cs
    public class ProductTabViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<Order> _orders;
        public List<Order> Orders
        {
            get => _orders;
            set
            {
                _orders = value;
                OnPropertyChanged();
            }
        }

        private List<Product> _products;
        public List<Product> Products
        {
            get => _products;
            set
            {
                _products = value;
                OnPropertyChanged();
            }
        }

        private Order _selectedOrder;
        public Order SelectedOrder
        {
            get => _selectedOrder;
            set
            {
                _selectedOrder = value;
                OnPropertyChanged();
            }
        }

        private Product _selectedProduct;
        public Product SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                OnPropertyChanged();
            }
        }

        private int _quantity = 1;
        public int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public ProductTabViewModel()
        {
            LoadSampleData();


            //SubmitCommand = new RelayCommand(Submit);
            //CancelCommand = new RelayCommand(Cancel);
        }

        private void LoadSampleData()
        {
            Orders = new List<Order>
        {
            new Order { Id = 1, OrderNumber = "ORD-2023-001" },
            new Order { Id = 2, OrderNumber = "ORD-2023-002" },
            new Order { Id = 3, OrderNumber = "ORD-2023-003" }
        };

            Products = new List<Product>
        {
            new Product { Id = 1, ProductName = "笔记本电脑", Price = 5999.99m },
            new Product { Id = 2, ProductName = "智能手机", Price = 3999.99m },
            new Product { Id = 3, ProductName = "无线耳机", Price = 499.99m },
            new Product { Id = 4, ProductName = "智能手表", Price = 1299.99m }
        };
        }

        private void Submit()
        {
            // 提交逻辑
        }

        private void Cancel()
        {
            // 取消逻辑
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
