using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class Customer
    {
        public string Name => "Hung";
        public int Age => 35;
        public int GetOrderByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Hello");
            }
            return 100;
        }

        public string GetFullName(string FirstName, string LastName)
        {
            return $"{FirstName} {LastName}";
        }
        public class LoyalCustomer : Customer
        {
            public int Discount { get; set; }
            public LoyalCustomer()
            {
                Discount = 10;
            }
        }
        public static class CustomerFactory
        {
            public static Customer CreateCustomerInstance(int orderCount)
            {
                if (orderCount <= 100)
                {
                    return new Customer();
                }
                else
                {
                    return new LoyalCustomer();
                }
            }
        }
    }
}
