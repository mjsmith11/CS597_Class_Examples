using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // imports

namespace Week1 //like a package
{
    class Student
    {
        private string firstname;
        private string lastname;
        private double gpa;

        public Student(string f,string l, double g)
        {
            firstname = f;
            lastname = l;
            gpa = g;
        }

        public void printInfo()
        {
            Console.WriteLine(firstname + " " + lastname + "'s GPA is " + gpa);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //string firstName;
            //firstName = Console.ReadLine();
            ////Console.WriteLine(firstName);
            ////datatypes: int,double,float,bool,char
            //int age;
            //age = Int32.Parse(Console.ReadLine()); //typecasting
            ////Console.WriteLine(age);
            //Console.WriteLine(firstName + " is " + age + " years old.");

            Student alice = new Student("Alice", "Smith", 3.95);
            alice.printInfo();
        }
    }
}
