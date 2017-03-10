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

        public static bool IsSolvablePuzzle(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
                if (array[i] > array[i + 1]) count++;
            return (count % 2 == 0);
        }

        public static Game2 Randomizer(Game SomeArray)
        {
            Random random = new Random();
            int[] matrix = new int[SomeArray.dimensions * SomeArray.dimensions];
            do
            {
                matrix = Enumerable.Range(0, matrix.Length).OrderBy(_ => random.Next()).ToArray();
            } while (IsSolvablePuzzle(matrix));
            return new Game2(matrix);
        }

        public bool Solved()
        {
            int orderValue = 1;

            for (int i = 0; i < dimensions; i++)
            {
                for (int j = 0; j < dimensions; j++)
                {
                    if ((((i != dimensions - 1) || (j != dimensions - 1)) && (Field[i, j] != orderValue)) || (Field[dimensions - 1, dimensions - 1] != 0))
                    {
                        return false;
                    }
                    orderValue++;
                }
            }
            return true;
        }

        public override void Shift(int value)
        {
            base.Shift(value);
            if (Solved()) throw new ArgumentException("Конец игры");
        }
    }
}