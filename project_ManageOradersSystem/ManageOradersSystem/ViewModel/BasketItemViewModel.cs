using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageOradersSystem.Models;
using MOSLibrary.Models;

namespace ManageOradersSystem.ViewModel
{
    /// <summary>
    /// 购物篮商品项的ViewModel
    /// 功能：包装NewBasketItem模型，提供属性变更通知支持
    /// </summary>
    public class BasketItemViewModel: ViewModelBase
    {
        private readonly NewBasketItem _model;

        /// <summary>
        /// 基于已有模型创建ViewModel
        /// </summary>
        /// <param name="model">从数据库获取的原始模型</param>
        public BasketItemViewModel(NewBasketItem model)
        {
            _model = model;
        }

        /// <summary>
        /// 便捷构造函数（用于新建商品项场景）
        /// </summary>
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

        /// <summary>
        /// 购物篮商品项ID
        /// </summary>
        public int IdBasketItem
        {
            get => _model.IdBasketItem;
            set
            {
                _model.IdBasketItem = value;
                RaisePropertyChanged();
            }
        }


        /// <summary>
        /// 关联的商品ID
        /// </summary>
        public short? IdProduct
        {
            get => _model.IdProduct;
            set
            {
                _model.IdProduct = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// 商品名称（显示用）
        /// </summary>
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

        /// <summary>
        /// 关联的购物篮导航属性
        /// </summary>
        public Basket? IdBasketNavigation
        {
            get => _model.IdBasketNavigation;
            set
            {
                _model.IdBasketNavigation = value;
                RaisePropertyChanged();
            }
        }


        /// <summary>
        /// 关联的商品导航属性
        /// </summary>
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
