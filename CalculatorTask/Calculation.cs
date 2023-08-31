using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask
{
    public class Calculation
    {
        public int CalculationId { get; set; }
        public string Operation { get; set; }
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public double Result { get; set; }
    }
}
