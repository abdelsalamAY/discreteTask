﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //project 1
            //write a c# program to writ the prime numbers from n1 to n2
            //the input: n1 and n2
            //the output: the list of the prime numbers from n1 to n2 
            //  Example: for the input numbers: n1 = 5 and n2 = 18, the outbut should be 
            // 5 //7 //11 //13 //17


            Console.WriteLine("enter n1");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter n2");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("the prime numbers between {0} and {1}", n1, n2);

            for (int i = n1; i <= n2; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                if (counter == 0 && i != 1)
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
    }
}
