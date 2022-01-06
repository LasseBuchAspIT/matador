using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg1
{
    class Car
    {
        public string make = "placeHolder";
        public string model = "placeHolder";
        public DateTime manufacturingDate = new DateTime(2020, 10, 10);


        public TimeSpan CurrentAge()
        {
            TimeSpan carAge;

            carAge = DateTime.Now - manufacturingDate;

            return carAge;
        }


    }
}
