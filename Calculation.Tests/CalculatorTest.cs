using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculation.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            var calc = new Calculator();
            var result = calc.Add(1, 2);
            Assert.Equal(3,result);
        }
        [Fact]
        public void Add_GivenTwoDoubleValues_ReturnsDouble()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.21, 3.51);
            Assert.Equal(4.7, result, 1);
        }
        [Fact]
        public void IsOdd_GivenOddValue_ReturnsTrue()
        {
            var calc = new Calculator();
            var result = calc.IsOdd(1);
            Assert.True(result);
        }
        [Fact]
        public void IsOdd_GivenEvenValue_ReturnsFalse()
        {
            var calc = new Calculator();
            var result = calc.IsOdd(1);
            Assert.False(result);
        }
        [Theory]
        [InlineData(1, true)]
        [InlineData(200, false)]
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            var calc = new Calculator();
            var result = calc.IsOdd(value);
            Assert.Equal(expected, result);
        }
        [Theory]
        //[MemberData(nameof(TestDataShare.IsOddOrEvenExternalData), MemberType = typeof(TestDataShare))]
        [IsOddOrEvenData]
        public void IsOdd_TestOddAndEvenShareData(int value, bool expected)
        {
            var calc = new Calculator();
            var result = calc.IsOdd(value);
            Assert.Equal(expected, result);
        }
    }
}
