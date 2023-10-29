using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNo._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           // Problem No.3

           long num = 600851475143;
           long largestPF = 0;
           long divisor = 2;


           while (num > 1)
           {
               if (num % divisor == 0)
               {
                   num = num / divisor;
                   largestPF = divisor;
               }
               else
               {
                   divisor++;
               }
           }
           Console.WriteLine($"Largest Prime Factor Of 600851475143 is {largestPF}" ) ;

           
        }
    }
}
