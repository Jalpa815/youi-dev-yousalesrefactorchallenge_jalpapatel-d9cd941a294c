using System;
using System.Collections.Generic;
using System.Text;

namespace YouiSales
{
    public class MotorCyclePolicy : Policy
    {

        public const int Motorcycle = 56;

        public MotorCyclePolicy(string policyHolderName, string description, int price)
            : base(policyHolderName, description, price)
        {
            PolicyHolderName = policyHolderName;
            Description = description;
            Price = price;
        }
    }
}
