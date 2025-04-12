using System;
using System.Collections.Generic;

namespace ManageOradersSystem.Models;

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
