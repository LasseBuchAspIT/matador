using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspit.BasicOop.Game
{
    class Die
    {
        Random rnd = new Random();
        public int value;

        public Die()
        {
            
        }
        public Die(int initialValue)
        {

        }

        public void Roll()
        {
            value = rnd.Next(1, 7);
        }

        public override string ToString()
        {
            if (value == 1)
            {
                return "\n\n\n\t*\t\n\n";
            }
            else if (value == 2)
            {
                return "\t*\n\n\n\n\n*\t";
            }
            else if (value == 3)
            {
                return "\t*\n\n\n    *      \n\n\n*";
            }
            else if (value == 4)
            {
                return "*\t*\n\n\n\n\n*\t*";
            }
            else if (value == 5)
            {
                return "*\t*\n\n    *    \n\n\n*\t*";
            }
            else if (value == 6)
            {
                return "*\t*\n\n*\t*\n\n*\t*";
            }
            else return "error";
        }

    }

}
