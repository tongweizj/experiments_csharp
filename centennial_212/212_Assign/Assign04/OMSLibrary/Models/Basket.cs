using System;
using System.Collections.Generic;

namespace OMSLibrary.Models;

public partial class Basket
{
    public int IdBasket { get; set; }

    public int? IdShopper { get; set; }

    public byte? Quantity { get; set; }

    public decimal? SubTotal { get; set; }

    public DateTime OrderDate { get; set; }

    public virtual ICollection<BasketItem> BasketItems { get; set; } = new List<BasketItem>();

    public virtual Shopper? IdShopperNavigation { get; set; }
}
