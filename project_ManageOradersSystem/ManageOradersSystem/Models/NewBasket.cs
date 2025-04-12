using MOSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOradersSystem.Models
{
    public partial class NewBasket
    {
        public int IdBasket { get; set; }

        public int? IdShopper { get; set; }
        public string? NameShopper { get; set; }

        public byte? Quantity { get; set; }

        public decimal? SubTotal { get; set; }

        public DateTime OrderDate { get; set; }

        public virtual ICollection<BasketItem> BasketItems { get; set; } = new List<BasketItem>();

        public virtual Shopper? IdShopperNavigation { get; set; }
    }
}
