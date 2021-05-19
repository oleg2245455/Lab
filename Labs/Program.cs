using System;

namespace Labs
{
    enum MyTask
    {
        Task1 = 1, Task2, 

    }
    class Program
    {
        static void Main(string[] args)
        {

            
            var result = MyTask.Task2;

            switch (result)
            {
                case MyTask.Task2:
                    {
                        RunFactorial();
                        break;
                    }
               
            }
        }
               
        private static void RunCalulator()
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


        private static void RunFactorial()
        {
            int num, fact = 1;
            Console.WriteLine("Enter a number :");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + num + "is :" + fact);
            Console.ReadLine();
        }

        private static void RunRandom()
        {

            Random random = new Random();
            int number = random.Next(1, 10);

            while (true)
            {
                Console.WriteLine("Give me number:");
                int userGuess = Int32.Parse(Console.ReadLine());

                if (userGuess == number)
                {
                    break;
                }
                else if (userGuess > number && userGuess > 0 && userGuess < 11)
                {
                    Console.WriteLine("To High");
                }
                else if (userGuess < number && userGuess > 0 && userGuess < 11)
                {
                    Console.WriteLine("To Low");
                }
                else
                {
                    Console.WriteLine("Guess out bounds");
                }


            }
            Console.WriteLine("Congratulation!!");
        }



    }
}

