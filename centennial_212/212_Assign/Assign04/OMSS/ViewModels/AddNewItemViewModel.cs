using OMSLibrary.DTOs;
using OMSLibrary.Models;
using OMSLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using OMSS.Commands;
using System.Windows;

namespace OMSS.ViewModels
{
    public class AddNewItemViewModel : INotifyPropertyChanged
    {
        private readonly DataService _service;

        public ObservableCollection<BasketDto> Baskets { get; } = new ObservableCollection<BasketDto>();
        public ObservableCollection<ProductDto> Products { get; } = new ObservableCollection<ProductDto>();

        private BasketDto _selectedBasket;
        public BasketDto SelectedBasket
        {
            get => _selectedBasket;
            set { _selectedBasket = value; OnPropertyChanged(); }
        }

        private ProductDto _selectedProduct;
        public ProductDto SelectedProduct
        {
            get => _selectedProduct;
            set { _selectedProduct = value; OnPropertyChanged(); }
        }

        private int _quantity = 1;
        public int Quantity
        {
            get => _quantity;
            set { _quantity = value; OnPropertyChanged(); }
        }

        public ICommand SaveCommand { get; }
        public ICommand CancelCommand { get; }

        /// <summary>当新项保存成功后触发</summary>
        public event EventHandler ItemAdded;
        /// <summary>用户点击取消时触发</summary>
        public event EventHandler CancelRequested;

        public AddNewItemViewModel()
        {
            _service = new DataService(new OmsContext());

            SaveCommand = new RelayCommand(async _ => await SaveAsync(), _ => CanSave());
            CancelCommand = new RelayCommand(_ => Cancel());

            // 启动时加载下拉框数据
            _ = LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            var baskets = await _service.GetAllBasketsAsync();
            foreach (var b in baskets) Baskets.Add(b);
            SelectedBasket = Baskets.FirstOrDefault();

            var products = await _service.GetAllProductsAsync();
            foreach (var p in products) Products.Add(p);
            SelectedProduct = Products.FirstOrDefault();
        }

        private bool CanSave() =>
            SelectedBasket != null &&
            SelectedProduct != null &&
            Quantity > 0;

        private async Task SaveAsync()
        {
            // 计算新 IdBasketItem
            var existing = await _service.GetBasketItemsAsync(SelectedBasket.IdBasket);
            int newId = existing.Any()
                ? existing.Max(i => i.IdBasketItem) + 1
                : 1;
            // 构建不含 Id 的新实体
            var newItem = new BasketItem
            {
                IdBasket = SelectedBasket.IdBasket,
                IdProduct = (short?)SelectedProduct.IdProduct,
                Quantity = (byte?)Quantity
            };

            try
            {
                // 把有事务和手动 id 逻辑封装好的方法调用进来
                await _service.AddBasketItemWithManualIdAsync(newItem);
                ItemAdded?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败：{ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Cancel() =>
            CancelRequested?.Invoke(this, EventArgs.Empty);

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
