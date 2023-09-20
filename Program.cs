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

                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        public static void Prompter()
        {

        }
    }
}
