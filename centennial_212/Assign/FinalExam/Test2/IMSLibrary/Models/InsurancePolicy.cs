using System;
using System.Collections.Generic;

namespace IMSLibrary.Models;

public partial class InsurancePolicy
{
    public string Id { get; set; } = null!;

    public string AgentId { get; set; } = null!;

    public string ProductCode { get; set; } = null!;

    public DateTime PolicyDate { get; set; }

    public decimal Premium { get; set; }

    public string Insured { get; set; } = null!;

    public virtual Agent Agent { get; set; } = null!;

    public virtual Product ProductCodeNavigation { get; set; } = null!;
}
