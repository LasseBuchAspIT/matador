using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flights
{
    class Luggage
    {
        private int weight;

        public int GetWeight { get => weight; }

        public void setWeight(int w)
        {
            weight = w;
        }


        public Luggage(int lWeight)
        {
            weight = lWeight;
        }
        


    }
}
