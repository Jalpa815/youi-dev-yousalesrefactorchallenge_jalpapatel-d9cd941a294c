using System;
using System.Collections.Generic;
using System.Text;

namespace YouiSales
{
  
    public class CarPolicy : Policy 
    {       

        public const int Car = 105;
        public CarPolicy(string policyHolderName, string description, int price)
            : base(policyHolderName ,description ,price)
        {
            PolicyHolderName = policyHolderName;
            Description = description;
            Price = price;
        }
    }
}
