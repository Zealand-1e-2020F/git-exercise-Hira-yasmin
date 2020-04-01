using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            myClass2 myclass1 = new myClass2("Hira", "poppelhusene", 2600, "glostrup");
            myClass2 myclass2 = new myClass2("Yasmin", "hedemarken", 2620, "albertslund");
            myclass1.ToString();

            System.Console.WriteLine(myclass1.ToString());


        }
    }
}
