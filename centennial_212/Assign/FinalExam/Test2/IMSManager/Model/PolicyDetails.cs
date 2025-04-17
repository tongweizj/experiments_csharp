using System;

namespace IMSManager.Model
{
    public class PolicyDetails
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public DateTime PolicyDate { get; set; }
        public decimal Premium { get; set; }
        public string Insured { get; set; }
        public PolicyDetails(string id, string productName, DateTime policyDate, decimal premium, string insured)
        {

            Id = id;
            ProductName = productName;
            PolicyDate = policyDate;
            Premium = premium;
            Insured = insured;

        }
    }
}
