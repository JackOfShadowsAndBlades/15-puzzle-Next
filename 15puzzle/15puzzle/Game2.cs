using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15puzzle
{
    class Game2 : Game
    {
        public Game2(params int[] SomeArray) : base(SomeArray)
        {
        }

        public static Game2 Randomizer(Game SomeArray)
        {
            Random random = new Random();
            int[] matrix = new int[SomeArray.dimensions * SomeArray.dimensions];
            matrix = Enumerable.Range(0, matrix.Length).OrderBy(_ => random.Next()).ToArray();
            return new Game2(matrix);
        }

        public bool Solved()
        {
            int orderValue = 1;

            for (int i = 0; i < dimensions; i++)
            {
                for (int j = 0; j < dimensions; j++)
                {
                    if ((i != dimensions - 1) || (j != dimensions - 1))
                    {
                        if (Field[i, j] != orderValue)
                        {
                            return false;
                        }
                        orderValue++;
                    }
                    else if (Field[dimensions - 1, dimensions - 1] != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}