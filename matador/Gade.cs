using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matador
{
    class Gade : Property
    {
        int houseAmount;
        double houseCost;
        public Gade(string name, int price, int rent, int _houseCost) : base(name, price, rent)
        {
            houseCost = _houseCost;
        }


    }
}
