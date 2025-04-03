using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut_2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempinF;
            double tempinC;

            Console.WriteLine("Enter the Temperature in Fehrenheit");

            tempinF = double.Parse(Console.ReadLine());

            tempinC = (tempinF - 32) * 5 / 9;

            Console.WriteLine("The Temperature in  Celsius "+ tempinC +" C");

            Console.ReadLine();

        }
    }
}
