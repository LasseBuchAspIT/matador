using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matador
{
    class Field
    {
        protected string name;

        public virtual void passed(Player p)
        {
            Console.WriteLine($"{p.Name} passed {name}");
            
        }
        public virtual void landed(Player p)
        {
            Console.WriteLine($"{p.Name} landed on {name}");
        }

        public Field(string fieldName)
        {
            name = fieldName;
        }

    }
}
