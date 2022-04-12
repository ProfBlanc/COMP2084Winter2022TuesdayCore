using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.Tests
{
    class Calculator
    {
        /*
         * 
         * methods
         * add(ition)
         * sub(traction)
         * 
         */

        public double Add(double n1, double n2)
        {

            return n1 + n2;
        }
        public double Sub(double n1, double n2) {

            return n1 - n2;
        }
        public double Div(double n1, double n2)
        {
            if (n2 == 0) {
                throw new DivideByZeroException("Second operand cannot be zero");
            }
            return n1 / n2;   //if n2 is 0, DivideByZeroException is invoked
        }
    }
}
