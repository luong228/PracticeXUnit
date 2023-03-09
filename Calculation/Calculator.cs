using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double AddDouble(double a, double b)
        {
            return a + b;
        }
        public bool IsOdd(int value)
        {
            return (value % 2) == 1;
        }
    }
}
