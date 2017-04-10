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
            Linq13();
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
       public static void Linq5()
        {
            List<string> names = new List<string> { "Alice", "Bob", "Carol", "Dave" };
            var firstCharacter =
                from n in names
                select n.Substring(0, 1);

            foreach(var n in firstCharacter)
            {
                Console.WriteLine(n);
            }
        }

        public static void Linq6()
        {
            List<string> sentences = new List<string> { "The quick brown fox jumped", "Hello world" };
            var words = from s in sentences
                        from w in s.Split(' ')
                        select w;

            foreach(var w in words)
            {
                Console.WriteLine(w);
            }
        }

        public static void Linq7()
        {
            string[] fruits = { "cherry", "banana", "pear" };
            string search = "pear";
            Console.WriteLine(fruits.Contains(search));
        }

        public static void Linq8()
        {
            int[] a = { 0, 2, 3 };
            int[] b = { 1, 2 };
            IEnumerable<int> u =a.Intersect(b);
            foreach (int arg in u)
                Console.WriteLine(arg);
        }

        public static void Linq9()
        {
            List<int> midterm = new List<int> { 87, 98, 76, 56, 24, 100 };
            Console.WriteLine(midterm.Average());
            Console.WriteLine(midterm.Min());
        }

        public static void Linq10()
        {
            int[] numbers = { 4, 2, 8, 0, 5, 1, 5, 4, 7, 5, 2, 8 };
            IEnumerable<int> arg = numbers.OrderByDescending(n => n).SkipWhile(n => n > 3); // skip on condition n>3
            //there is also take and takewhile that do the oposite of skip
            //IEnumerable<int> arg = numbers.Skip(3); //skip the first 3 numbers
            foreach (int i in arg)
                Console.WriteLine(i);
        }

        public static void Linq11()
        {
            string[] fruits = { "cherry", "banana", "pear" };
            IEnumerable<string> f = fruits.OrderBy(fruit => fruit.Length).ThenBy(fruit => fruit);

            foreach(string i in f)
            {
                Console.WriteLine(i);
            }
        }

        public static void Linq13()
        {
            string[] names = { "Alice", "Bob", "Carol" };
            var containsA = names.Where(x => x.Contains('a'));
            foreach (var c in containsA)
                Console.WriteLine(c);
        }
    }
}
