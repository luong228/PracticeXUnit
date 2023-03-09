using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace Calculation.Tests
{
    public class NameTest
    {
        [Fact]
        public void MakeFullNameTest()
        {
            var name = new Name();
            var result = name.MakeFullName("Hung", "Than");
            //Assert.StartsWith("Hun", result);
            //Assert.Equal("Hung Than", result, ignoreCase:true);
            //Assert.Contains("Hung", result);
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }

        [Fact]
        public void NickName_MustBeNull()
        {
            var name = new Name();
            //name.NickName = "S";
            Assert.Null(name.NickName);
        }
        [Fact]
        public void MakeFullName_AlwaysReturnValue()
        {
            var name = new Name();
            var result = name.MakeFullName("Hung", "Than");
            Assert.NotNull(result);
            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}
