using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class VowelAndConsonant
    {
        public static void CheckAlphabet()
        {
            Console.WriteLine("Enter a character:");
            char ch = Convert.ToChar(Console.ReadLine());
            //Condition for Vowel
            if(ch =='a' || ch== 'e' || ch =='i'|| ch =='o' || ch =='u' ||ch == 'A'|| ch =='E' || ch == 'I'||ch =='O'|| ch == 'U')
            {
                Console.WriteLine(ch + " is Vowel");
            }
            else 
            {
                Console.WriteLine(ch + " is a Consonant");
            }
           
        }
    }
}
