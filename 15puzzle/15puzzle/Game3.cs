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
        public readonly List<KeyValuePair<int, Tuple<int,int>>> TurnsHistory = new List<KeyValuePair<int, Tuple<int, int>>>();

        public Game3(params int[] historyList) : base(historyList)
        {
            TurnsHistory = new List<KeyValuePair<int, Tuple<int, int>>>();
        }

        public override void Shift(int value)
        {
            base.Shift(value);
            TurnsHistory.Add(new KeyValuePair<int, Tuple<int, int>>(value,GetLocation(value)));
        }
    }
}
