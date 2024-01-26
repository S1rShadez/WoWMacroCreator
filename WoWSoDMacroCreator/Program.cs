using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWSoDMacroCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the WoW Classic macro creator!");

            while (true)
            {
                switch (Ask("What would you like to do?\n1. Create character macro\n2. Create combat macro"))
                {
                    case "1":
                        Console.WriteLine("Tests");
                        break;
                    case "2":
                        Console.WriteLine("Test 2");
                        break;
                    default:
                        Console.WriteLine("Unrecognized input, try again");
                        Continue();
                        Console.Clear();
                        continue;
                }
                break;
            }
        }

        public static string Ask(string s)
        {
            Console.WriteLine(s);
            return Console.ReadLine();
        }

        public static void Continue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
