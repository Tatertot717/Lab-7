using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    interface ICalcOp
    {
        public float Add(float augend, float addend);
        public float Subtract(float minuend, float subtrahend);
        public float Multiply(float multiplier, float multiplicand);
        public float Divide(float dividend, float divisor);


    }
}
