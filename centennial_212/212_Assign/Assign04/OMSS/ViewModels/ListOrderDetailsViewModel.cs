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

namespace OMSS.ViewModels
{
    public class ListOrderDetailsViewModel : INotifyPropertyChanged
    {
        private readonly DataService _service;

        public ObservableCollection<BasketDto> Baskets { get; } = new ObservableCollection<BasketDto>();

        private BasketDto _selectedBasket;
        public BasketDto SelectedBasket
        {
            get => _selectedBasket;
            set
            {
                _selectedBasket = value;
                OnPropertyChanged();
                _ = LoadBasketItemsAsync();
            }
        }

        public ObservableCollection<BasketItemDto> BasketItems { get; } = new ObservableCollection<BasketItemDto>();

        public ListOrderDetailsViewModel()
        {
            _service = new DataService(new OmsContext());
        }

        /// <summary>
        /// 加载所有 Basket 到 ComboBox
        /// </summary>
        public async Task LoadBasketsAsync()
        {
            var list = await _service.GetAllBasketsAsync();
            Baskets.Clear();
            foreach (var b in list)
                Baskets.Add(b);
        }

        /// <summary>
        /// 根据 SelectedBasket 加载对应的 BasketItems 到 DataGrid
        /// </summary>
        private async Task LoadBasketItemsAsync()
        {
            BasketItems.Clear();
            if (SelectedBasket == null) return;

            var items = await _service.GetBasketItemsAsync(SelectedBasket.IdBasket);
            foreach (var it in items)
                BasketItems.Add(it);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
