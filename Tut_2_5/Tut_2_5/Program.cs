using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,num3;

            int totalsum;
            Console.WriteLine("Enter a number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number");
            num3= int.Parse(Console.ReadLine());

            totalsum = num1 + num2 + num3;
            Console.WriteLine("The total is: "+totalsum);

            Console.ReadLine();



        }
    }
}
