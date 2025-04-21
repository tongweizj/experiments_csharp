using System;
using System.Collections.Generic;

namespace OMSLibrary.Models;

public partial class Product
{
    public short IdProduct { get; set; }

    public string? ProductName { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public virtual ICollection<BasketItem> BasketItems { get; set; } = new List<BasketItem>();
}
