using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4Lab5_Blockbuster
{
    public class DVD : Movie
    {
        public DVD(string Title, int RunTime, Category Category, List<string> Scenes)
            : base(Title, Category, RunTime, Scenes)
        {

        }
        public override void Play()
        {
            Console.WriteLine("What scene would you like to watch?");
            bool gettingNumber = true;
            while (gettingNumber)
            {
                Console.WriteLine($"Enter a number from 0 to {Scenes.Count-1}.");
                string userInput = Console.ReadLine();
                bool isANumber = int.TryParse(userInput, out int value);
                if (isANumber)
                {
                    for (int i = value; i < Scenes.Count; i++)
                    {
                        Console.WriteLine($"{i}. {Scenes[i]}");
                    }
                    gettingNumber = false;
                }
                else
                {
                    Console.WriteLine("Sorry, that does not appear to be a number. Please try again.");
                }
            }
            
        }
    }
}
