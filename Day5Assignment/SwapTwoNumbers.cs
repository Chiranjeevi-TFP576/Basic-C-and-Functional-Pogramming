using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class SwapTwoNumbers
    {
        public static void SwapNumbers()
        {
            int num1, num2,temp;
            Console.WriteLine("Enter the Numbers for num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Numbers for num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nBefore Swaping num1 = {0} and num2 ={1}",num1,num2);
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("\nAfter Swaping num1={0} and num2={1}",num1,num2);
            Console.ReadLine();
        }
    }
}
