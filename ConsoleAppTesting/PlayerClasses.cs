using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTesting
{
    internal class PlayerClasses
    {
        private List<string> classes = new List<string>();
        public PlayerClasses() {
            classes.Add("Warrior");
            classes.Add("Priest");
        }
        public void DisplayClasses() {
            Console.WriteLine("Choose one class:");
            foreach (string playerClass in classes)
            {
            Console.WriteLine(playerClass);
            }
    }
        public string ChooseClass()
        {
            Console.Write("Well what are you? ");
            string chosenClass = Console.ReadLine();

            if (classes.Contains(chosenClass))
            {
                Console.WriteLine($"You have chosen {chosenClass}!");
                return chosenClass;
            }
            else
            {
                Console.WriteLine("Invalid class choice. Please choose from the available classes.");
                return null;
            }
        }
    }
}
