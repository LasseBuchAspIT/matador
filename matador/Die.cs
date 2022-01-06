using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matador
{
    class Die
    {
        private int value;

        public int Value { get => value; }

        public int roll()
        {
            Random rnd = new Random();
            value = rnd.Next(1, 7);
            return Value;
        }
    }
}
