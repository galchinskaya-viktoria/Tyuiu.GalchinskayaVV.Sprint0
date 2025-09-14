using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.GalchinskayaVV.Sprint0.Task4.Vo.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
            { 
                return a + b; 
            }

        public static double Division(int a, int b)
        {
            return a / b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
    }
}
