using System;
using System.Reflection.Metadata;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Ayush");

            //variable
            int a;
            a = 20;

            double c = 3.5;
            a = 3;

            string b = "string";

            Console.WriteLine(a);

            Console.WriteLine($"apple {a} ayush rai {b}");

            //Constant
            const string name = "Ayush";
            Console.WriteLine(name);


            Console.WriteLine($"This is for c" + c.GetType());
            Console.WriteLine(c);
            //Conversion
            c = Convert.ToInt32(c);
            Console.WriteLine(c);


            //The below method makes the unecessary writing in the cmd dissaper 
            Console.ReadKey();
        }
    } 
}
