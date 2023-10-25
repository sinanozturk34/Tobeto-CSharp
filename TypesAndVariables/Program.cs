using System;
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
            char character = 'A';
            string city = "Ankara";
            bool condition = false; //deger tipi
            byte number4 = 255;
            short number3 = 32767;
            int number1 = 2147483647;
            long number2= 9223372036854775807;
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
            //char veri tipi
            Console.WriteLine("Character4 is {0}", (int)character);//sayı dönüşür int ile

           
            Console.ReadLine();
        }
    }
}
