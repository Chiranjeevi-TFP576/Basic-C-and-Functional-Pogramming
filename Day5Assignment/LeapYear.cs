using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class LeapYear
    {
        public void LaepYearCheck()
        {
            Console.WriteLine("Enter Year Number whether to Check Leap");
            int Year = Convert.ToInt32(Console.ReadLine());

            while (Year < 1000)
            {
                Console.WriteLine("Enter year with 4 digt number");
                Year = Convert.ToInt32(Console.ReadLine());
            }
            if (Year % 4 == 0)
            {
                Console.WriteLine(" is a Leap Year:",Year);
            }
            else if(Year % 400 ==0)
            {
                Console.WriteLine(" is a Leap Year:", Year);
            }
            else
            {
                Console.WriteLine(" is not a Leap Year:", Year);
            }

        }
    }
}
