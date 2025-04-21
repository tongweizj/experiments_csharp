using System;
using System.Collections.Generic;

namespace OMSLibrary.Models;

public partial class BasketItem
{
    public int IdBasketItem { get; set; }

    public short? IdProduct { get; set; }

    public byte? Quantity { get; set; }

    public int? IdBasket { get; set; }

    public virtual Basket? IdBasketNavigation { get; set; }

    public virtual Product? IdProductNavigation { get; set; }
}
