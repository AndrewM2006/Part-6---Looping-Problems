using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6___Looping_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string menuOption;
                Console.Clear();
                Console.WriteLine("Press 1 for Prompter");
                Console.WriteLine("Press 2 for Percent Passing");
                Console.WriteLine("Press 3 for Odd Sum");
                Console.WriteLine("Press 4 for Random Number");
                Console.WriteLine("Press Q for Quit");
                menuOption =Console.ReadLine();
                if (menuOption == "1")
                {
                    Prompter();
                }
                else if (menuOption == "2")
                {

                }
                else if (menuOption == "3")
                {

                }
                else if (menuOption == "4")
                {

                }
                else if (menuOption == "Q"||menuOption=="q")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        public static void Prompter()
        {
            double num1=0, num2=0, inputNum=0;
            bool valid=false;
            Console.Write("Enter a Number: ");
            while (!valid)
            {
                if (double.TryParse(Console.ReadLine(), out num1))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("That is not a valid number, try again!");
                }
            }
            valid = false;
            Console.Write("Enter a Second Number: ");
            while (!valid)
            {
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("That is not a valid number, try again!");
                }
            }
            Console.WriteLine($"Please enter a value between {Math.Min(num1, num2)} and {Math.Max(num1, num2)}");
            do
            {
                valid = false;
                while (!valid)
                {
                    if (double.TryParse(Console.ReadLine(), out inputNum))
                    {
                        valid = true;
                        if (inputNum < Math.Min(num1, num2) || inputNum > Math.Max(num1, num2))
                        {
                            Console.WriteLine("That is not a valid number, try again!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid number, try again!");
                    }
                }
            } while (inputNum < Math.Min(num1, num2) || inputNum > Math.Max(num1, num2));
            Console.WriteLine($"Good Job! {inputNum} is between {Math.Min(num1, num2)} and {Math.Max(num1, num2)}!");
            System.Threading.Thread.Sleep(3000);
        }
    }
}
