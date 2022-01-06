using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matador
{
    class Start : Field
    {
        double reward;

        public override void passed(Player p)
        {
            p.Wallet += reward;
            Console.WriteLine($"{p.Name} was rewarded {reward}kr for passing start\nTheir balance is now {p.Wallet}");
            
        }

        public override void landed(Player p)
        {
            p.Wallet += reward;
            Console.WriteLine($"{p.Name} was rewarded {reward}kr for landing on start\nTheir balance is now {p.Wallet}");
        }

        public Start(double fieldReward) : base("Start")
        {
            reward = fieldReward;
        }
    }
}
