﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            /*
            int number = 100;
            while (number>=0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
            */
            /*
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
            */

            string[] students = new string[3] {"Engin","Derin","Salih"};
            foreach(var student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }
        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i = i - 2) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");

        }
    }
}
