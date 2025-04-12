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
    public class DataProvider
    {

        public static List<NewBasket> GetBasketData()
        {
            using (OmsContext dbContext = new OmsContext())
            {
                Console.WriteLine("Querying for baskets");

                List<NewBasket> basketList = dbContext.Baskets
                .Join(
                    dbContext.Shoppers,
                    Basket => Basket.IdShopper,
                    Shopper => Shopper.IdShopper,
                    (Basket, Shopper) => new NewBasket
                    {
                        IdBasket = Basket.IdBasket,
                        IdShopper = Basket.IdShopper,
                        NameShopper = $"{Shopper.Email} {Basket.IdBasket}", 
                          
                        Quantity = Basket.Quantity,
                        SubTotal = Basket.SubTotal,
                        OrderDate = Basket.OrderDate
                    })
                .ToList();

                return basketList;
            }
        }


        public static List<NewBasketItem> GetBasketItemData()
        {
            using (OmsContext dbContext = new OmsContext())
            {
                List<NewBasketItem> basketItemList = dbContext.BasketItems
               .Join(
                   dbContext.Products,
                   NewBasketItem => NewBasketItem.IdProduct,
                   Product => Product.IdProduct,
                   (NewBasketItem, Product) => new NewBasketItem
                   {
                       IdBasketItem = NewBasketItem.IdBasketItem,
                       IdProduct = NewBasketItem.IdProduct,
                       NameProduct = Product.ProductName,
                       PriceProduct = Product.Price,
                       Quantity = NewBasketItem.Quantity,
                       IdBasket = NewBasketItem.IdBasket
                   })
               .ToList();
                return basketItemList;
            }
        }

        public static List<Product> GetProductData()
        {
            using (OmsContext dbContext = new OmsContext())
            {
                Console.WriteLine("Querying for produts");

                // 直接执行查询并转换为 List<Basket>
                List<Product> ProductList = dbContext.Products
                    .OrderBy(b => b.IdProduct)
                    .ToList(); // 关键：调用 ToList() 执行查询并转换

                return ProductList;
            }
        }
    }
}
