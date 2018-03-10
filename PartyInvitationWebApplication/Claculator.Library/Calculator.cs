using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claculator.Library
{
    public class Calculator
    {
        public int? Num1 { get; set; }
        public int? Num2 { get; set; }
        public int Divide(int num1, int num2)
        {
            int result = num1 / num2; ;
            //try
            //{
            //   result = num1 / num2;
            //}
            //catch (Exception ex)
            //{

            //}
            return result; 
        }
    }
}
