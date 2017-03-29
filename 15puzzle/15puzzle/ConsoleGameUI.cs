using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15puzzle
{
    class ConsoleGameUI
    {
        IPlayable objIPlayable;

        public ConsoleGameUI(IPlayable game)
        {
            objIPlayable = game;
        }

        public void ReadValue()
        {
            DiplayField();
            while (!objIPlayable.Solved())
            {
                int number;
                if (Int32.TryParse(Console.ReadLine(), out number))
                {
                    if (number >= 0)
                    {
                        objIPlayable.Shift(number);
                        DiplayField();
                    }
                    else
                    {
                        throw new ArgumentException("Введено отрицательное число");
                    }
                }
                else
                {
                    throw new ArgumentException("Введено не число");
                }
            }
            throw new ArgumentException("Игра закончена");
        }

        public void DiplayField()
        {
            for (int i = 0; i < objIPlayable.Dimensions; i++)
            {
                for (int j = 0; j < objIPlayable.Dimensions; j++)
                {
                    Console.Write("{0}\t", objIPlayable[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}