using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut_2_6
{
    class Program
    {
        static void Main(string[] args)
        {

            int inohrsworked;
            double dperhrpayed,dSalary;

            dperhrpayed = 0;
            inohrsworked = 0;

            Console.WriteLine("Enter the number of hours worked");

            inohrsworked = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the rate of pay per an hour");

            dperhrpayed = double.Parse(Console.ReadLine());

            dSalary = inohrsworked * dperhrpayed;

            Console.WriteLine("The Salary is R "+dSalary);

            Console.ReadLine();     
        }
    }
}
