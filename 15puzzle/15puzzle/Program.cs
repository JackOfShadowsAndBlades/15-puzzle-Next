using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15puzzle
{
    class Program
    {
        public static void DisplayCurrentState(int[,] array)
        {
            for (int i = 0; i < Math.Sqrt(array.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(array.Length); j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            // Game game = new Game(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0);
            // //Game anothergame = Game.FromCSV("text.csv");
            // Game2 game2 = Game2.Randomizer(game);
            // Game.PrintInfo(game2.Field);
            // Console.WriteLine(game2.GetLocation(5));
            //// Console.WriteLine(game.GetLocation(5));

            Game3 game = new Game3(1, 2, 3, 4, 0, 6, 7, 8 , 5);
            DisplayCurrentState(game.Field);
           // game.Shift(4);
            DisplayCurrentState(game.Field);
           // Console.WriteLine(game.TurnsHistory[0]);
            game.Rollback(1);
        }
    }
}
