using System;

namespace Class
{
    internal class Class
    {
        public string property = "Data";

        public void print()
        {
            Console.WriteLine("Printing a message");
        }

        class Program
        {
            static void Main(string[] args)
            {
                Class myObject = new Class();
                Console.WriteLine(myObject.property);
                myObject.print();
                Console.ReadKey();

                Console.WriteLine("\nObject2\n");

                Class myObject2 = new();

                Console.WriteLine(myObject.property);
                myObject.print();

                myObject2.property = "Data, Data";
                Console.WriteLine(myObject2.property);
                myObject2.print();

                Console.ReadKey();
            }
        }
    }
}