using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut_2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double sum;

            Console.WriteLine("Enter a number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number");
            num2 = int.Parse(Console.ReadLine());

            sum = num1 / num2;

            Console.WriteLine("The Answer is "+sum);
            Console.ReadLine();
        }
    }
}
