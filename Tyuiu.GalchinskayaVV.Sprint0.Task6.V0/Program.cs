using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GalchinskayaVV.Sprint0.Task6.V0.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива =" + DataService.AdditionArray(arraynums));
            Console.WriteLine("Разность эллементов массива =" + DataService.SubtractionArray(arraynums));
            Console.WriteLine("Произведение эллементов массива =" +  DataService.MultiplicationArray(arraynums));

            Console.ReadKey();
        }
    }
}
