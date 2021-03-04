using System;

namespace Test_Task.Lucky_Ticket_NET5
{
    class Program
    {
        private static void PrintHappyTicket(string number)
        {
            int sumRight = 0, sumLeft = 0;
            if (number.ToString().Length == 4 || number.ToString().Length == 6 || number.ToString().Length == 8)
            {
                int digits = (int)Math.Floor(Math.Log10(Int32.Parse(number)) + 1);

                for (int i = 0; i < digits; i++)
                {
                    int digit = (int)(Int32.Parse(number) / (Math.Pow(10, i))) % 10;
                    if (i >= digits / 2)
                        sumLeft += digit;
                    else
                        sumRight += digit;
                }
                Console.WriteLine("Your ticket number is: " + number);
            }

            else if (number.ToString().Length == 5)
            {
                int digits = (int)Math.Floor(Math.Log10(Int32.Parse(number.ToString().PadRight(6, '0'))) + 1);
                Console.WriteLine("Your ticket number is: " + "0" + number);
                for (int i = 0; i < digits; i++)
                {
                    int digit = (int)(Int32.Parse(number) / (Math.Pow(10, i))) % 10;
                    if (i >= digits / 2)
                        sumLeft += digit;
                    else
                        sumRight += digit;
                }
            }
            else if (number.ToString().Length == 7)
            {
                int digits = (int)Math.Floor(Math.Log10(Int32.Parse(number.ToString().PadRight(8, '0'))) + 1);
                Console.WriteLine("Your ticket number is: " + "0" + number);
                for (int i = 0; i < digits; i++)
                {
                    int digit = (int)(Int32.Parse(number) / (Math.Pow(10, i))) % 10;
                    if (i >= digits / 2)
                        sumLeft += digit;
                    else
                        sumRight += digit;
                }
            }

            if (sumLeft == sumRight)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You have a lucky ticket ({0} equals {1})", sumLeft, sumRight);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, you have a usual ticket", sumLeft, sumRight);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Hello! Write your ticket number:");
                string number = Console.ReadLine();

                if (number.ToString().Length < 4)
                {
                    Console.WriteLine("Your number is too short!");
                    continue;
                }
                if (number.ToString().Length > 8)
                {
                    Console.WriteLine("Your number is too long!");
                    continue;
                }
                if (number.ToString().Length == 5 || number.ToString().Length == 7)
                {
                    Console.WriteLine($"Your word length is odd {number.ToString().Length}");
                    Console.WriteLine($"Your new ticket: { "0" + number.ToString()}");
                    PrintHappyTicket(number);
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                PrintHappyTicket(number);
            }
        }
    }
}
