using System;

namespace Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 168; int num2 = 521;


            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");



            Console.WriteLine("type a number, and press Enter");


            Console.WriteLine("type another number, and then press Enter");


            Console.WriteLine("Select the arithmetic operation");
            Console.WriteLine("\tq - Multiplication");
            Console.WriteLine("\tw - Divide");
            Console.WriteLine("\te - Addition");
            Console.WriteLine("\tr - Suptracting");
            Console.WriteLine("\tt - Exponantiation");
            Console.Write("Your choice");

            switch (Console.ReadLine())
            {
                case "q":
                    Console.WriteLine($"Your result :  {num1 * num2} =" + (num1 * num2));
                    break;
                case "w":
                    Console.WriteLine($"Your result :  {num1 / num2} =" + (num1 / num2));
                    break;
                case "e":
                    Console.WriteLine($"Your result :  {num1 + num2} =" + (num1 + num2));
                    break;
                case "r":
                    Console.WriteLine($"Your result :  {num1 - num2} =" + (num1 - num2));
                    break;
                case "t":
                    Console.WriteLine($"Your result : {num1 != num2} =" + (num1 != num2));
                    break;
            }

            Console.Write("Peress any key to close Calculator console app...");
            Console.ReadKey();
        }
    }
}
