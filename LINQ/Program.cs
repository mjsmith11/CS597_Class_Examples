using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ //Language integrated query. Run a query on any kind of collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq4();
            Console.Read();
        }

        public static void Linq0()
        {
            int[] numbers = { 4, 2, 8, 0, 5, 1, 5, 4, 7, 5, 2, 8 };
            var numbersPlusOne =
                from n in numbers
                select n + 1;
            foreach(var i in numbersPlusOne)
            {
                Console.WriteLine(i);
            }
        }
        
        public static void Linq1()
        {
            int[] numbers = { 4, 2, 8, 0, 5, 1, 5, 4, 7, 5, 2, 8 };
            var numbersLessThan5 =
                from n in numbers
                where n < 5
                select n;
            foreach (var i in numbersLessThan5)
            {
                Console.WriteLine(i);
            }
        }

        public static void Linq2()
        {
            string[] fruits = { "cherry", "banana", "pear" };
            var sortedFruits =
                from f in fruits
                orderby f.Length, f //orderby f.Length descending
                select f;

            foreach (var f in sortedFruits)
            {
                Console.WriteLine(f);
            }
        }

        public static void Linq3()
        {
            string[] names = { "AlicE", "bOB", "cARol", "DavE" };
            var upperLower =
                from n in names
                select new { UpperCase = n.ToUpper(), LowerCase = n.ToLower()}; //anonymous type. like a struct and dynamic object
            foreach(var ul in upperLower)
            {
                Console.WriteLine(ul.UpperCase);
            }
        }
        
        public static void Linq4()
        {
            int[] numbers = { 4, 2, 8, 0, 5, 1, 5, 4, 7, 5, 2, 8 };
            int[] moreNumbers = { 3, 7, 9, 2 };
            var tuple =
                from a in numbers
                from b in moreNumbers
                where a < b
                select new { a, b };
            foreach(var t in tuple)
            {
                Console.WriteLine("(" + t.a + ", " + t.b + ")");
            }
        }
           
    }
}
