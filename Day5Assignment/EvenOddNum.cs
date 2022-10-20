using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class EvenOddNum
    {
        public static void CheckEvenOdd()
        {
            int i;
            Console.WriteLine("Enter a number for Checking");
            i = Convert.ToInt32(Console.ReadLine());
            if(i%2 ==0)
            {
                Console.WriteLine("Entered number is Even Number");
            }
            else
            {
                Console.WriteLine("Entered number is Odd");
            }
        }
    }
}
