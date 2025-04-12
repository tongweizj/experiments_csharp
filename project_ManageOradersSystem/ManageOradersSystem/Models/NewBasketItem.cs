using MOSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOradersSystem.Models
{
    public partial class NewBasketItem
    {
        public int IdBasketItem { get; set; }

        public short? IdProduct { get; set; }
        public string? NameProduct { get; set; }
        public decimal? PriceProduct { get; set; }
        public byte? Quantity { get; set; }

        public int? IdBasket { get; set; }

        public virtual Basket? IdBasketNavigation { get; set; }

        public virtual Product? IdProductNavigation { get; set; }
    }
}
