using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            myclass myclass1 = new myclass("Hira", "poppelhusene", 2600, "glostrup");
            myclass myclass2 = new myclass("Yasmin", "hedemarken", 2620, "albertslund");
            myclass1.ToString();

            System.Console.WriteLine(myclass1.ToString());


        }
    }
}
