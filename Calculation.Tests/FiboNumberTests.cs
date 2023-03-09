using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Calculation.Tests
{
    public class FiboFixture : IDisposable
    {
        public FiboNumber fibo => new FiboNumber();

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    public class FiboNumberTests : IClassFixture<FiboFixture>, IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly MemoryStream memoryStream;
        private readonly FiboFixture _fiboFixture;

        //public FiboNumber fibo = new FiboNumber();
        public FiboNumberTests(ITestOutputHelper testOutputHelper, FiboFixture fiboFixture)
        {
            _testOutputHelper = testOutputHelper;
            _fiboFixture = fiboFixture;
            _testOutputHelper.WriteLine("Constructor");

            memoryStream = new MemoryStream();
        }
        [Fact]
        [Trait("Category","Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            _testOutputHelper.WriteLine("Does not include 0");
            var fibo = _fiboFixture.fibo;
            Assert.All(fibo.FiboNumbers, n => Assert.NotEqual(0, n));
        }
        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboInclude13()
        {
            _testOutputHelper.WriteLine("Test Fibo include 13");
            var fibo = _fiboFixture.fibo;
            Assert.Contains(13, fibo.FiboNumbers);
        }
        [Fact]
        [Trait("Category","Fibo")]
        public void FiboDoesNotInclude4()
        {
            _testOutputHelper.WriteLine("Test Fibo does not include 4");
            var fibo = _fiboFixture.fibo;
            Assert.DoesNotContain(4, fibo.FiboNumbers);
        }
        [Fact]
        [Trait("Category","Fibo")]
        public void CheckCollection()
        {
            _testOutputHelper.WriteLine("Test Collection Fibo");
            var exceptedCollection = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };
            var fibo = _fiboFixture.fibo;
            Assert.Equal(exceptedCollection, fibo.FiboNumbers);
        }

        public void Dispose()
        {
            memoryStream.Close();
        }
    }
}
