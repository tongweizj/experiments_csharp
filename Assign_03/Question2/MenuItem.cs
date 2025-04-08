using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class MenuItem
    {
        public string Category { get; set; }  // Beverage, Appetizer, etc.
        public string Name { get; set; }      // Dish name
        public decimal Price { get; set; }    // Price
    }
}
