using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Harmonics
    {
        public static void HarmonicNumber()
        {
            double harmonicSum = 0;
            Console.WriteLine("Enter a Number to find Harmonic:" );
            double num = Convert.ToDouble(Console.ReadLine());
            for (double i = 1;i<=num;i++)
            {
                Console.Write("1/{0}+",i);
                harmonicSum += (1 / i);
            }
            Console.WriteLine("\n The Sum of harmonic number is "+ harmonicSum);
        }
    }
}
