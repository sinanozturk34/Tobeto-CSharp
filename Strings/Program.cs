using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Engin Demiroğ";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Derin Demiroğ";
           

            // ğ ile mi bitiyor?
            bool result3 = sentence.EndsWith("ğ");
            Console.WriteLine(result3);

            // My name ile mi başlıyor?
            bool result4 = sentence.StartsWith("My name");
            Console.WriteLine(result4);


            // Bulamadığında -1 döndürür.
            var result5 = sentence.IndexOf("namee");
            Console.WriteLine(result5);

            // Bulduğu ilk ifadeyi getirir.

            var result6 = sentence.IndexOf(" ");
            Console.WriteLine(result6);

            // Aramaya sondan başlar. IndexOf ile aynıdır.
            var result7 = sentence.LastIndexOf(" ");
            Console.WriteLine(result7);

            // 0'dan itibaren Hello, ekle.
            var result8 = sentence.Insert(0, "Hello, ");
            Console.WriteLine(result8);

            // Metini parçalamaya yarar.
            // 3'den itibaren 4 tane al
            var result9 = sentence.Substring(3, 4);
            Console.WriteLine(result9);

            // Küçük harf çevirmeye yarar.
            var result10 = sentence.ToLower();
            Console.WriteLine(result10);

            // Büyük harf çevirmeye yarar.
            var result11 = sentence.ToUpper();
            Console.WriteLine(result11);

            // Değiştirmeye yarar.
            var result12 = sentence.Replace(" ", "-");
            Console.WriteLine(result12);

            // Metinden belli bir indexten sonrasını atar.
            var result13 = sentence.Remove(2, 5);
            Console.WriteLine(result13);

           



          
            Console.WriteLine(result2);



            /*
            string city = "Ankara";
           // Console.WriteLine(city[0]);
           foreach(var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "İstanbul";
            //string result = city + city2;

            Console.WriteLine(String.Format("{0} {1}",city,city2));
            //Console.WriteLine(result);
           
            */
               Console.ReadLine();
        }
    }
}
