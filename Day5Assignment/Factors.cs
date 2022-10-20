using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Factors
    {
        public static void FactorsofNumber()
        {
            int i, num ;
            Console.WriteLine("Enter any Number to check PrimeFactor ");
            num = Convert.ToInt32(Console.ReadLine());
            
            for(i = 2;num > 1;i++)
            {
                if(num % i == 0)
                {
                    int x = 0;
                    while(num % i == 0)
                    {
                        num /= i;
                        x++;
                    }
                    Console.WriteLine($"{i} is prime factor \n {x} times");
                }
                
            }

        }
    }
}
