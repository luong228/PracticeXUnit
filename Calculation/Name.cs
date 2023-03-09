using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class Name
    {
        public string NickName { get; set; }
        public string MakeFullName(string FirstName, string LastName)
        {
            return $"{FirstName} {LastName}";
        }
    }
}
