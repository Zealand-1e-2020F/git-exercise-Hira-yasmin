using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            myClass myclass1 = new myClass("Hira", "poppelhusene", 2600);
            myClass myclass2 = new myClass("Yasmin", "hedemarken", 2620);
            myclass1.ToString();

            System.Console.WriteLine(myclass1.ToString());


        }
    }
}
