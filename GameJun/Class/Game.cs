using GameJun.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJun.Class
{
    class Game : AbstractGame
    {
        public override void SelectPlayers()
        {
            Random random = new Random();
            int rand = random.Next(0, 3);
            Console.WriteLine("player 2 выберете персонажа: Human, Chert, Ubuntu");
            string input = Console.ReadLine();
            if (input == "Human")
            {
                player2 = new Human();
            }
            else if (input == "Chert")
            {
                player2 = new Chert();
            }
            else if (input == "Ubuntu")
            {
                player2 = new Ubuntu();
            }
            else
            {
                Console.WriteLine("You idiot! Your character is random.");
                if (rand == 0)
                {
                    player2 = new Human();
                }
                else if (rand == 1)
                {
                    player2 = new Chert();
                }
                else if (rand == 2)
                {
                    player2 = new Ubuntu();
                }
            }

            rand = random.Next(0, 3);
            Console.WriteLine("player 1 выберете персонажа: Human, Chert, Ubuntu");
            input = Console.ReadLine();
            if (input == "Human")
            {
                player1 = new Human();
            }
            else if (input == "Chert")
            {
                player1 = new Chert();
            }
            else if (input == "Ubuntu")
            {
                player1 = new Ubuntu();
            }
            else
            {
                Console.WriteLine("You idiot! Your character is random.");
                if (rand == 0)
                {
                    player1 = new Human();
                }
                else if (rand == 1)
                {
                    player1 = new Chert();
                }
                else if (rand == 2)
                {
                    player1 = new Ubuntu();
                }
            }
        }

        public override void Start()
        {
            while (player1.IsAlive() && player2.IsAlive())
            {
                GameStep();
            }
            if (player1.IsAlive())
            {
                Console.WriteLine("player2 is win");
            }
            else
            {
                Console.WriteLine("player2 is win");
            }
        }

        protected override void GameStep()
        {
            player1.Attack(player2);
            player2.Attack(player1);
            Console.WriteLine($"Игрок 1. HP: {player1.Health}\nИгрок 2. HP: {player2.Health}");
        }
    }
}
