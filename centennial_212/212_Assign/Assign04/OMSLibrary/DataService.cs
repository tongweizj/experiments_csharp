using Microsoft.EntityFrameworkCore;
using OMSLibrary.DTOs;
using OMSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMSLibrary
{






    /// <summary>
    /// 提供对 OMS 数据库的异步 CRUD 操作
    /// </summary>
    public class DataService
    {
        private readonly OmsContext _context;

        public DataService(OmsContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 获取所有购物篮（包含 ShopperEmail）
        /// </summary>
        public async Task<List<BasketDto>> GetAllBasketsAsync()
        {
            return await _context.Baskets
                .Join(
                    _context.Shoppers,
                    b => b.IdShopper,
                    s => s.IdShopper,
                    (b, s) => new BasketDto
                    {
                        IdBasket = b.IdBasket,
                        ShopperEmail = s.Email
                    }
                )
                .ToListAsync();
        }

        /// <summary>
        /// 获取指定购物篮下的所有项，包含产品名称、单价和数量
        /// </summary>
        public async Task<List<BasketItemDto>> GetBasketItemsAsync(int basketId)
        {
            return await _context.BasketItems
                .Where(bi => bi.IdBasket == basketId)
                .Join(
                    _context.Products,
                    bi => bi.IdProduct,
                    p => p.IdProduct,
                    (bi, p) => new BasketItemDto
                    {
                        IdBasketItem = bi.IdBasketItem,
                        IdBasket = (int)bi.IdBasket,
                        IdProduct = (int)bi.IdProduct,
                        ProductName = p.ProductName,
                        UnitPrice = (decimal)p.Price,
                        Quantity = (int)bi.Quantity
                    }
                )
                .ToListAsync();
        }


        /// <summary>
        /// 获取所有产品的简化信息（Id, Name, Price）
        /// </summary>
        public async Task<List<ProductDto>> GetAllProductsAsync()
        {
            return await _context.Products
                .Select(p => new ProductDto
                {
                    IdProduct = p.IdProduct,
                    Name = p.ProductName,
                    Price = (decimal)p.Price
                })
                .ToListAsync();
        }

        /// <summary>
        /// 向数据库中新增一个 BasketItem 实体
        /// </summary>
        public async Task AddBasketItemAsync(BasketItem newItem)
        {
            try
            {
                _context.BasketItems.Add(newItem);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                // 抛出一个包含底层错误信息的新异常，便于调试
                var sqlError = ex.InnerException?.Message ?? ex.Message;
                throw new InvalidOperationException($"保存 BasketItem 时出错：{sqlError}", ex);
            }
        }

        /// <summary>
        /// 计算下一个可用的 IdBasketItem（当前最大值 + 1）
        /// </summary>
        public async Task<int> GetNextBasketItemIdAsync()
        {
            // 如果表里没有记录就返回 1
            var maxId = await _context.BasketItems
                                      .MaxAsync(bi => (int?)bi.IdBasketItem)
                                      .ConfigureAwait(false)
                      ?? 0;
            return maxId + 1;
        }

        /// <summary>
        /// 在事务中新增 BasketItem，确保获取 ID 和插入是一致的
        /// </summary>
        public async Task AddBasketItemWithManualIdAsync(BasketItem newItem)
        {
            // 开启事务，并设置为可防止“丢失更新”的隔离级别
            // Serializable 隔离可以避免两次 Max( ) 同时拿到相同值
            using var trx = await _context.Database
                                           .BeginTransactionAsync(IsolationLevel.Serializable)
                                           .ConfigureAwait(false);

            // 1) 计算新 ID
            var nextId = await GetNextBasketItemIdAsync()
                             .ConfigureAwait(false);
            newItem.IdBasketItem = nextId;

            // 2) 添加并保存
            _context.BasketItems.Add(newItem);
            await _context.SaveChangesAsync()
                          .ConfigureAwait(false);

            // 3) 提交事务
            await trx.CommitAsync()
                     .ConfigureAwait(false);
        }
    }
}
