﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
     class Program
    {
        static void Main(string[] args)
        {
            //Values Types
            // Console.WriteLine("Hello World!");
            double number5 = 10.4;
            decimal number6 = 10.4m;
            char character = 'A';
            string city = "Ankara";
            bool condition = false; //deger tipleri
            byte number4 = 255;
            short number3 = 32767;
            int number1 = 2147483647;
            long number2= 9223372036854775807;
            var number7 = 10;//int
            number7 = 'A';
            //number7 = "A"; //string
            
            //integer veri tipi
            Console.WriteLine("Number1 is {0}",number1);
            //long veri tipi
            Console.WriteLine("Number2 is {0}", number2);
            //short veri tipi
            Console.WriteLine("Number3 is {0}", number3);
            //byte veri tipi
            Console.WriteLine("Number4 is {0}", number4);
            //double veri tipi
            Console.WriteLine("Number5 is {0}", number5);
            //var veri tipi
            Console.WriteLine("Number7 is {0}", number7);
            //char veri tipi
            Console.WriteLine("Character4 is {0}", (int)character);//sayı dönüşür int ile
            //enum-tip dönüşümleri
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday=10,Tuesday=20,Wednesday=30,Thursday,Friday,Saturday,Sunday
    }
}
