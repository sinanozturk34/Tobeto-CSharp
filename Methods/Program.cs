﻿using System;
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
            /*
            Add();//metot çagırdık
            Add();
            Add();
            var result = Add2(4);  */
            /*
            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(out number1, number2);//ref:referans tip olur ve deger degişir 30 olur
            Console.WriteLine(result2);//degişken 30 oluyor
            Console.WriteLine(number1);//deger tipler: 20 oluyor çıktı
            //Console.WriteLine(result);//ekrana yazmak ıcın degısken atadık
            */


            //Console.WriteLine(Multiply(2, 4));
            //Console.WriteLine(Multiply(2, 4,5));

            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));
            Console.ReadLine();
        }
        static void Add() //metot
        {
            Console.WriteLine("Added!!!");
        }
        static int Add2(int x,int number1=20, int number2=30) //default degerleri (sabit deger) metot sonunda olur,sadece ilk degere deger veremezsin
        {//metot hesaplama yaptık
            var result = number1 + number2;
            return result;
            //return number1 + number2;
        }
        static int Add3(out int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2 * number3;
        }
        static int Add4(int number,params int[] numbers)
        {
            return numbers.Sum();
        }
       

    }
}
