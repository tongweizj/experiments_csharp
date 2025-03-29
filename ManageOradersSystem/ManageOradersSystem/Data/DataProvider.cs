using ManageOradersSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOradersSystem.Model
{
    public class DataProvider
    {

        public static List<Menu> GetData()
        {
            List<Menu>  Menus = new List<Menu>{
                // Beverages
                new Menu { Category = "Beverage", Name = "Coca-Cola", Price = 2.50m },
                new Menu { Category = "Beverage", Name = "Orange Juice", Price = 3.00m },
                new Menu { Category = "Beverage", Name = "Lemonade", Price = 3.50m },
                new Menu { Category = "Beverage", Name = "Iced Coffee", Price = 4.00m },
                new Menu { Category = "Beverage", Name = "Green Tea", Price = 2.80m },
                new Menu { Category = "Beverage", Name = "Milkshake", Price = 5.00m },
                new Menu { Category = "Beverage", Name = "Espresso", Price = 2.75m },
                new Menu { Category = "Beverage", Name = "Hot Chocolate", Price = 3.75m },
                new Menu { Category = "Beverage", Name = "Mineral Water", Price = 2.00m },
                new Menu { Category = "Beverage", Name = "Fruit Smoothie", Price = 4.50m },

                // Appetizers
                new Menu { Category = "Appetizer", Name = "Caesar Salad", Price = 6.50m },
                new Menu { Category = "Appetizer", Name = "Bruschetta", Price = 7.00m },
                new Menu { Category = "Appetizer", Name = "Mozzarella Sticks", Price = 6.75m },
                new Menu { Category = "Appetizer", Name = "Spring Rolls", Price = 5.50m },
                new Menu { Category = "Appetizer", Name = "Buffalo Wings", Price = 8.00m },
                new Menu { Category = "Appetizer", Name = "Garlic Bread", Price = 4.50m },
                new Menu { Category = "Appetizer", Name = "Stuffed Mushrooms", Price = 6.80m },
                new Menu { Category = "Appetizer", Name = "French Fries", Price = 4.00m },
                new Menu { Category = "Appetizer", Name = "Onion Rings", Price = 4.50m },
                new Menu { Category = "Appetizer", Name = "Cheese Platter", Price = 9.00m },

                // Main Course
                new Menu { Category = "Main Course", Name = "Grilled Ribeye Steak", Price = 22.00m },
                new Menu { Category = "Main Course", Name = "Salmon Fillet", Price = 18.50m },
                new Menu { Category = "Main Course", Name = "Chicken Alfredo Pasta", Price = 14.75m },
                new Menu { Category = "Main Course", Name = "BBQ Ribs", Price = 19.99m },
                new Menu { Category = "Main Course", Name = "Vegetable Stir-Fry", Price = 12.50m },
                new Menu { Category = "Main Course", Name = "Beef Tacos", Price = 11.00m },
                new Menu { Category = "Main Course", Name = "Lobster Tail", Price = 25.00m },
                new Menu { Category = "Main Course", Name = "Mushroom Risotto", Price = 15.20m },
                new Menu { Category = "Main Course", Name = "Margherita Pizza", Price = 13.50m },
                new Menu { Category = "Main Course", Name = "Teriyaki Chicken", Price = 14.00m },

                // Desserts
                new Menu { Category = "Dessert", Name = "Chocolate Lava Cake", Price = 8.00m },
                new Menu { Category = "Dessert", Name = "Tiramisu", Price = 7.50m },
                new Menu { Category = "Dessert", Name = "Cheesecake", Price = 6.80m },
                new Menu { Category = "Dessert", Name = "Apple Pie", Price = 5.50m },
                new Menu { Category = "Dessert", Name = "Crème Brûlée", Price = 9.00m },
                new Menu { Category = "Dessert", Name = "Ice Cream Sundae", Price = 6.00m },
                new Menu { Category = "Dessert", Name = "Pavlova", Price = 7.20m },
                new Menu { Category = "Dessert", Name = "Churros", Price = 5.80m },
                new Menu { Category = "Dessert", Name = "Fruit Tart", Price = 6.90m },
                new Menu { Category = "Dessert", Name = "Brownie with Ice Cream", Price = 7.00m }
            };
            return Menus;
        }

        public static List<Basket> GetBasketData()
        {
            using (OmsContext dbContext = new OmsContext())
            {
                Console.WriteLine("Querying for baskets");

                // 直接执行查询并转换为 List<Basket>
                List<Basket> basketList = dbContext.Baskets
                    .OrderBy(b => b.IdBasket)
                    .ToList(); // 关键：调用 ToList() 执行查询并转换

                return basketList;
            }
        }


        public static List<BasketItem> GetBasketItemData()
        {
            using (OmsContext dbContext = new OmsContext())
            {
                Console.WriteLine("Querying for baskets");

                // 直接执行查询并转换为 List<Basket>
                List<BasketItem> baskeItemtList = dbContext.BasketItems
                    .OrderBy(b => b.IdBasketItem)
                    .ToList(); // 关键：调用 ToList() 执行查询并转换

                return baskeItemtList;
            }
        }

    }
}
