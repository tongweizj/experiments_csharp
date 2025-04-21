using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMSLibrary.DTOs
{
    // BasketDto.cs

        /// <summary>
        /// 用于展示所有购物篮（Basket）的简化数据传输对象
        /// </summary>
        public class BasketDto
        {
            /// <summary>
            /// 购物篮主键
            /// </summary>
            public int IdBasket { get; set; }

            /// <summary>
            /// 该购物篮所属用户的电子邮件
            /// </summary>
            public string ShopperEmail { get; set; }
        }
    

}
