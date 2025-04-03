using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut_2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double dSurfaceArea, dLenght, dBreath;

            Console.WriteLine("Enter the Lenght of the rectangle in cm");
            dLenght = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Breath of the rectangle in cm");
            dBreath = float.Parse(Console.ReadLine());
            dSurfaceArea = dLenght * dBreath;
            Console.WriteLine("The Surface Area is : "+ dSurfaceArea +" cm2 of the reactangle");
            Console.ReadLine();




        }
    }
}
