using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculation.Tests
{
    [Collection("Customer")]
    public class CustomerDetailTests
    {
        private readonly CustomerFixture _customerFixture;
        public CustomerDetailTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        [Trait("Category", "Customer")]
        public void GetFullName_GivenFirstAndLastName_ReturnsFullName()
        {
            var customer = _customerFixture.customer;
            Assert.Equal("Hung Than", customer.GetFullName("Hung", "Than"));
        }
    }
}
