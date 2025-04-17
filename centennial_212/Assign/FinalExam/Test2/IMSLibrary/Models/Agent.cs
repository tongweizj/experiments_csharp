using System;
using System.Collections.Generic;

namespace IMSLibrary.Models;

public partial class Agent
{
    public string Id { get; set; } = null!;

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<InsurancePolicy> InsurancePolicies { get; set; } = new List<InsurancePolicy>();
}
