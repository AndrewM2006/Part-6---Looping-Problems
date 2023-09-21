using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
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
                    PercentPassing();
                }
                else if (menuOption == "3")
                {
                    OddSum();
                }
                else if (menuOption == "4")
                {
                    RandomNumbers();
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
        public static void PercentPassing()
        {
            double above70=0, total=0, grades;
            string inputString;
            Console.WriteLine("Enter as many test scores as you want, enter a blank value to advance.");
            do
            {
                inputString = Console.ReadLine();
                if (double.TryParse(inputString, out grades)||inputString=="")
                {
                    if (inputString != "")
                    {
                        if (grades >= 0 && grades <= 100)
                        {
                            total++;
                            if (grades > 70)
                            {
                                above70++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Grades Should be Between 0-100");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter A Numeric Value");
                }
            } while (inputString != "");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.WriteLine($"{Math.Round(above70 / total*100, 2)}% of scores entered were above 70%");
            System.Threading.Thread.Sleep(3000);
        }
        public static void OddSum()
        {
            int number=0, addition=-1, sum=0;
            bool valid=false;
            Console.Write("Enter an Positive Whole Number: ");
            while(!valid)
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number < 0)
                    {
                        Console.WriteLine("Please Enter an Positive Whole Number");
                    }
                    else
                    {
                        valid = true;
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Whole Number");
                }
            }
            for (int i = 0; i < Math.Ceiling((double)number/2); i++)
            {
                addition += 2;
                sum += addition;
            }
            Console.WriteLine(sum);
            System.Threading.Thread.Sleep(3000);
        }
        public static void RandomNumbers()
        {
            int num1 = 0, num2 = 0;
            bool valid = false;
            Random generator=new Random();
            Console.Write("Enter a Whole Number: ");
            while (!valid)
            {
                if (int.TryParse(Console.ReadLine(), out num1))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("That is not a valid number, try again!");
                }
            }
            valid = false;
            Console.Write("Enter a Second Whole Number: ");
            while (!valid)
            {
                if (int.TryParse(Console.ReadLine(), out num2))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("That is not a valid number, try again!");
                }
            }
            for (int i = 0; i < 25; i++)
            {
                if (i < 24)
                {
                    Console.Write(generator.Next(Math.Min(num1, num2), Math.Max(num1, num2) + 1) + ", ");
                }
                else
                {
                    Console.WriteLine(generator.Next(Math.Min(num1, num2), Math.Max(num1, num2) + 1));
                }
            }
            System.Threading.Thread.Sleep(5000);
        }
    }
}
