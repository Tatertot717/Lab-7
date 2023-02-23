using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Calculator : ICalcOp
    {
        public float Add(float augend, float addend)
        {
            float sum = augend + addend;
            return (sum);
        }
        public float Subtract(float minuend, float subtrahend) 
        {
            float difference = minuend - subtrahend;
            return(difference);
        }
        public float Multiply(float multiplier, float multiplicand) 
        {
            float product = multiplier* multiplicand;
            return(product);
        }
        public float Divide(float dividend, float divisor) 
        {
            float quotient = dividend / divisor;
            return(quotient);
        }


    }
}
