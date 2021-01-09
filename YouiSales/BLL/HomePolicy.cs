using System;
using System.Collections.Generic;
using System.Text;

namespace YouiSales
{
    public class HomePolicy : Policy
    {

        public const int Home = 235;

        public HomePolicy(string policyHolderName, string description, int price)
            : base(policyHolderName, description, price)
        {
            PolicyHolderName = policyHolderName;
            Description = description;
            Price = price;
        }
    }
}
