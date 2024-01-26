using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WoWSoDMacroCreator.Program;

namespace WoWSoDMacroCreator
{
    public class CombatCommands
    {
        static string SelectMechanic()
        {
            string text = "";
            while (true)
            {
                switch (Ask("Select combat mechanic:\n1. Cast spell/ability"))
                {
                    case "1":
                        text += "/cast";
                        break;
                    default:
                        Console.WriteLine("Invalid option selected");
                        Continue();
                        Console.Clear();
                        continue;
                }
                break;
            }

            return text;
        }

        static string AddModifier()
        {
            string text = "[";
            switch(Ask("Who do you want to target?\n1. Ally\n2. Enemy\n3. Self"))
            {
                case "1":
                    if(Ask("Is the friendly alive? y/n").ToLower() == "y")
                    {
                        text += "help, nodead";
                    }
                    else
                    {
                        text += "help, dead";
                    }
                    break;
            }

            return text;
        }
    }
}
