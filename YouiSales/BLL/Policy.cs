using System;

namespace YouiSales
{
    public class Policy
    {
      
        public Policy(string policyHolderName, string description, int price)
        {
            PolicyHolderName = policyHolderName;
            Description = description;
            Price = price;
        }

        public string PolicyHolderName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

    }
}
