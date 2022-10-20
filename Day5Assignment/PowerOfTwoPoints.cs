using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class PowerOfTwoPoints
    {
        public void PowerOfTwo()
        {
            Console.WriteLine("Enter a Number");
            int Number = Convert.ToInt32(Console.ReadLine());
           while (Number < 0 || Number >= 31)
            {
                Console.WriteLine("Please Enter a Valid Number :");
                Number = Convert.ToInt32(Console.ReadLine());
            }
            for(int i =1;i<=Number;i++)
            {
                Console.WriteLine("PowerOfTwo of Two is :" +Math.Pow(2, i));
            }
        }
    }
}
