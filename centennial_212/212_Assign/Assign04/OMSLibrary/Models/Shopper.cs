using System;
using System.Collections.Generic;

namespace OMSLibrary.Models;

public partial class Shopper
{
    public int IdShopper { get; set; }

    public string Email { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? StateProvince { get; set; }

    public string? Country { get; set; }

    public string? ZipCode { get; set; }

    public virtual ICollection<Basket> Baskets { get; set; } = new List<Basket>();
}
