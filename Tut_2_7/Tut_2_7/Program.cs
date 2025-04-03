using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxtemp, mintemp,avetemp;
            maxtemp = 0;
            mintemp = 0;
            avetemp = 0;
            Console.WriteLine("Enter the maximum temperature");
            maxtemp = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the minimum temperature");
            mintemp = double.Parse(Console.ReadLine());

            avetemp = (maxtemp + mintemp) / 2;

            Console.WriteLine("The Average Temperature is : "+ avetemp);
            Console.ReadLine();
        }
    }
}
