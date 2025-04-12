using ManageOradersSystem.Models;
using ManageOradersSystem.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOSLibrary.Models;


namespace ManageOradersSystem.Model
{
    /// <summary>
    /// 数据提供者接口
    /// 定义获取业务数据的方法契约
    /// </summary>
    public interface IDataProvider
    {
        /// <summary>
        /// 异步获取购物篮数据（包含关联的购物者信息）
        /// </summary>
        Task<List<NewBasket>> GetBasketDataAsync();

        /// <summary>
        /// 异步获取购物篮商品明细数据（包含关联的商品信息）
        /// </summary>
        Task<List<NewBasketItem>> GetBasketItemDataAsync();
        /// <summary>
        /// 异步获取所有商品数据
        /// </summary>
        Task<List<Product>> GetProductDataAsync();
    }

    /// <summary>
    /// 数据提供者实现类
    /// 封装所有数据库访问操作
    /// </summary>
    public class DataProvider: IDataProvider
    {

        /// <summary>
        /// 构造函数（保留DI兼容性，实际未使用注入的上下文）
        /// </summary>
        /// <param name="dbContext">理论上可注入的DbContext（当前实现中未使用）</param>
        public DataProvider(OmsContext dbContext)
        {
            
        }
        /// <summary>
        /// 异步获取购物篮数据
        /// 返回格式：购物篮信息 + 关联购物者邮箱
        /// </summary>
        public async Task<List<NewBasket>> GetBasketDataAsync()
        {
            using (var context = new OmsContext())  // 每次创建新实例
            {
                return await context.Baskets
                .Join(context.Shoppers,
                    b => b.IdShopper,  // 购物篮关联购物者的外键
                    s => s.IdShopper,  // 购物者主键
                    (b, s) => new NewBasket  // 结果映射
                    {
                        IdBasket = b.IdBasket,
                        IdShopper = b.IdShopper,
                        NameShopper = $"{s.Email} {b.IdBasket}",
                        Quantity = b.Quantity,
                        SubTotal = b.SubTotal,
                        OrderDate = b.OrderDate
                    })
                .ToListAsync(); // 异步执行查询
            }
        }


        /// <summary>
        /// 异步获取购物篮商品明细
        /// 返回格式：商品明细 + 关联商品名称和价格
        /// </summary>
        public async Task<List<NewBasketItem>> GetBasketItemDataAsync()
        {
            using (var context = new OmsContext())  // 每次创建新实例
            {
                return await context.BasketItems
                .Join(context.Products,
                    i => i.IdProduct, // 购物篮关联购物者的外键
                    p => p.IdProduct,
                    (i, p) => new NewBasketItem
                    {
                        IdBasketItem = i.IdBasketItem,
                        IdProduct = i.IdProduct,
                        NameProduct = p.ProductName,
                        PriceProduct = p.Price,
                        Quantity = i.Quantity,
                        IdBasket = i.IdBasket
                    })
                .ToListAsync();
            }
        }

        /// <summary>
        /// 异步获取所有商品数据
        /// 按商品ID排序返回
        /// </summary>
        public async Task<List<Product>> GetProductDataAsync()
        {
            using (var context = new OmsContext())  // 每次创建新实例
            {
                return await context.Products
                .OrderBy(p => p.IdProduct)
                .ToListAsync();
            }
        }
    }
}
