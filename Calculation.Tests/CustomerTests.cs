using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static Calculation.Customer;

namespace Calculation.Tests
{
    [Collection("Customer")]
    public class CustomerTests
    {
        private readonly CustomerFixture _customerFixture;
        public CustomerTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        [Trait("Category", "Customer")]
        public void CheckNameNotEmpty()
        {
            var customer = _customerFixture.customer;
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }
        [Fact]
        [Trait("Category", "Customer")]
        public void CheckLegitForDiscount() 
        {
            var customer = _customerFixture.customer;
            Assert.InRange(customer.Age, 25, 40);
        }
        [Fact]
        [Trait("Category", "Customer")]
        public void GetOrdersByName() {
            var customer = _customerFixture.customer;
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrderByName(""));
            Assert.Equal("Hello", exceptionDetails.Message);

        }
        [Fact]
        [Trait("Category", "Customer")]
        public void LoyalCustomerForOrderG100()
        {
            var customer = CustomerFactory.CreateCustomerInstance(105);
            var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
            Assert.Equal(10, loyalCustomer.Discount);
        }
    }
}
