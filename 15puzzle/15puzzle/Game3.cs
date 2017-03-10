using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace _15puzzle
{

    class Game3 : Game2
    {
        public readonly List<int> TurnsHistory = new List<int>();

        public Game3(params int[] historyList) : base(historyList)
        {
            TurnsHistory = new List<int>();
        }

        public override void Shift(int value)
        {
            base.Shift(value);
            TurnsHistory.Add(value);
        }

        public void Rollback(int value)
        {
            for (int i = 0; i < value; i++)
            {
                int a = TurnsHistory[TurnsHistory.Count - 1];
                TurnsHistory.RemoveAt(TurnsHistory.Count - 1);
                base.Shift(a);
            }

        }
    }
}
