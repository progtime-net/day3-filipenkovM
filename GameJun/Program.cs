using GameJun.Interfaces;
using GameJun.Class;

namespace GameJun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractGame game = new Game();
            game.SelectPlayers();
            game.Start();
        }
    }
}