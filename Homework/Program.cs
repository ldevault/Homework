using System;
using System.Collections.Generic;

namespace Homework
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                string[] optionArray = { "List Classes", "Add Class" };

                Console.WriteLine("What do you want to do...");

                for (var i = 0; i < optionArray.Length; i++)
                {
                    Console.WriteLine(i + " : " + optionArray[i]);
                }
                Console.WriteLine("Q : Quit");
                Console.Write("?");
                string choice = Console.ReadLine();
                if (choice.ToUpper() == "Q")
                { 
                    break; 
                }

                int opt;
                bool result = Int32.TryParse(choice, out opt);
                if (result && opt >= 0 && opt < optionArray.Length)
                {
                    Console.WriteLine("You selected: " + optionArray[opt]);
                }
                else
                {
                    Console.WriteLine("That isn't a valid option.");
                    continue;
                }
            }
        }
    }

}
