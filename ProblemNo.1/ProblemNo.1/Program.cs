﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNo._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Problem No.1

            int a = 0;
            for (int i = 1; i < 1000; i++) 
            {



                if (i % 3 == 0 || i % 5 == 0)
                {
                    a += i;

                    //a = a + i;
                }
            }
            Console.WriteLine(a);

            Console.ReadKey();
            
        }
    }
}
