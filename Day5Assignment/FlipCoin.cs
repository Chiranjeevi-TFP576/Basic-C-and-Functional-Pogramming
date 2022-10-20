using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class FlipCoin
    {
        public static void Flip_Percentage()
        {
            int Head = 0;
            int Tail = 0;
            Random random = new Random();
            Console.WriteLine(" enter the number you want to Flip");
            int NumberofFlip = Convert.ToInt32(Console.ReadLine());
            while (NumberofFlip<=0)
            {
                Console.WriteLine("Enter the valid number greater than zero");
                NumberofFlip = Convert.ToInt32(Console.ReadLine());
            }
            for (int i=0;i<NumberofFlip; i++)
            {
                int value = random.Next(0,2);
                if (value < 0.5)
                {
                    Head++;
                }
                else 
                {
                    Tail++;
                }
            }
            float headpercentage = (float)Head * 100 / NumberofFlip;
            float tailpercentage = (float)Tail * 100 / NumberofFlip;
            Console.WriteLine("Head percentage is:" +headpercentage+"%");
            Console.WriteLine("Tail percentage is :"+ tailpercentage+"%");
        }
    }
}
