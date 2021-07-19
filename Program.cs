using System;
using System.Threading;

namespace myFirst_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Chamika Dimantha";
            String desc = "I am new to programming .NET";


            Console.WriteLine("My name is " + name + " & " + desc);

            getUserInput();

        }

        // My new function to print input rule
        static void printRule()
        {
            Console.WriteLine("Please enter only number, If you enter a letter you will get a error message.");
        }

        // Print the rule for 100 times
        static void printNameFor100Times()
        {
            for (int i = 0; i <= 100; i++)
            {
                printRule();
            }
        }

        // Change console colro
        static void colorChange()
        {
            // Store the current console color
            ConsoleColor currentColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("My New Color is ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Dark Green");

            // Restore current console color
            Console.ForegroundColor = currentColor;
        }

        static void getUserInput()
        {
            Random randomObject = new Random();

            

            while(true)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Enter Your Question : ");
                String answer = Console.ReadLine();

                // Programe will terminate when user input 'quit' as an answer 
                if(answer.ToLower() == "quit")
                {
                    Console.WriteLine("..ENDING..");
                    break;
                }

                // Get a random number to sleep the program. Adding 1 to avoid return 0 value
                int randomSleep = randomObject.Next(4) + 1;

                Console.WriteLine("Working on it, Stand by...");
                Thread.Sleep(randomSleep * 1000);

                int random = randomObject.Next(4);

                switch (random)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Yes Sammani..");
                        break;

                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("May be yes Sammani..");
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("No Sammani..sorry!!!");
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Hell noo Sammani noo....");
                        break;
                }


            }

            Console.ForegroundColor = ConsoleColor.White;


        }

    }
}
