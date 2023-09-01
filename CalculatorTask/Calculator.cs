using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask
{
    public static class Calculator
    {
        public static INumber<T> Sum<T>(T x, T y) where T : INumber<T>
		{
			return x + y;
		}
}
}
