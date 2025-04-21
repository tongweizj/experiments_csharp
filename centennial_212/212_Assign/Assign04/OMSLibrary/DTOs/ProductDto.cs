using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMSLibrary.DTOs
{
   

// ProductDto.cs

    /// <summary>
    /// 用于展示产品（Product）的简化数据传输对象
    /// </summary>
    public class ProductDto
    {
        /// <summary>
        /// 产品主键
        /// </summary>
        public int IdProduct { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { get; set; }
    }

}