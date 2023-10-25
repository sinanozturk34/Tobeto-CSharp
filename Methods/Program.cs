using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();//metot çagırdık
            Add();
            Add();
            var result = Add2(20,30);
            Console.WriteLine(result);//ekrana yazmak ıcın degısken atadık
            Console.ReadLine();
        }
        static void Add() //metot
        {
            Console.WriteLine("Added!!!");
        }
        static int Add2(int number1, int number2)
        {//metot hesaplama yaptık
            var result = number1 + number2;
            return result;
            //return number1 + number2;
        }
    }
}
