using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AllTheTasks
{
    internal class Game
    {
        private int rand1 = 3;
        private int rand2 = 8;
        private int points = 0;
        public void LoadGame()
        {
            Console.Clear();
            rand1 = RandomNumber();
            rand2 = RandomNumber();

            Console.Write(rand1);
            Console.Write(FindSymbol());
            Console.Write(rand2.ToString().PadRight(57) + $"Points: {points}\n");
            Console.Write("\nIs the first number greater, equal or lesser than the second number?: ");
        }

        private string FindSymbol()
        {
            if (rand1 == rand2)
            {
                return " = ";
            }
            else if (rand1 > rand2)
            {

                return " > ";
            }
            else if (rand1 < rand2)
            {
                return " < ";
            }
            else return " ";
        }

        public void StartGame()
        {
            while (true)
            {
                LoadGame();
                HandleUserInput(Console.ReadLine());
                LoadGame();
            }
        }

        private void HandleUserInput(string userInput)
        {
            Console.WriteLine();
            if ((userInput == ">" && rand1 > rand2) ||
                (userInput == "<" && rand1 < rand2) ||
                (userInput == "=" && rand1 == rand2))
            {
                points++;
            }

            else
            {
                points--;
            } 
        }

        private int RandomNumber()
        {
            Random rand = new Random();
            int randomValue = rand.Next(0, 12);

            return randomValue;
        }


    }
}
