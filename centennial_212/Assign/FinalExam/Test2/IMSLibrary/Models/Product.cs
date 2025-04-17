using System;
using System.Collections.Generic;

namespace IMSLibrary.Models;

public partial class Product
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<InsurancePolicy> InsurancePolicies { get; set; } = new List<InsurancePolicy>();
}
