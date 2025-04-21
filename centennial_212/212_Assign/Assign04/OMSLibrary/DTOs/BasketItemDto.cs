using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMSLibrary.DTOs
{
    
        /// <summary>
        /// 用于展示购物篮项（BasketItem）的简化数据传输对象，包含产品信息及数量
        /// </summary>
        public class BasketItemDto
        {
            /// <summary>
            /// 购物篮项主键
            /// </summary>
            public int IdBasketItem { get; set; }

            /// <summary>
            /// 所属购物篮的主键
            /// </summary>
            public int IdBasket { get; set; }

            /// <summary>
            /// 产品主键
            /// </summary>
            public int IdProduct { get; set; }

            /// <summary>
            /// 产品名称（从 ProductDto.Name 取得）
            /// </summary>
            public string ProductName { get; set; }

            /// <summary>
            /// 产品单价（从 ProductDto.Price 取得）
            /// </summary>
            public decimal UnitPrice { get; set; }

            /// <summary>
            /// 购买数量
            /// </summary>
            public int Quantity { get; set; }

            /// <summary>
            /// 小计，计算公式：UnitPrice * Quantity
            /// </summary>
            public decimal Total => UnitPrice * Quantity;
        }
    }

