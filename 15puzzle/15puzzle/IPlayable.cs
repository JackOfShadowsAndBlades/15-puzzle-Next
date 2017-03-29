using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15puzzle
{
    interface IPlayable
    {
        void Randomizer(int[] SomeArray);
        bool Solved();
        void Shift(int value);

        int Dimensions { get; }
        int this[int x, int y] { get; }
    }
}