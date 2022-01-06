using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Driver
    {
        public static void Menzaner()
        {
            Person p1 = new Person("Person1", 110);
            Person p2 = new Person("Person2", 80);
            Person p3 = new Person("Person3", 141);
            Person p4 = new Person("Person4", 90);

            Person[] personArr = new Person[4] {p1, p2, p3, p4};

            int total = 0;

            foreach(Person p in personArr)
            {
                total += p.Iq;
                if(p.Iq > 140)
                {
                    Console.WriteLine($"{p.Name} er en menzaner!");
                }
            }

            total /= 4;

            Console.WriteLine("Den gennemsnitlige iq er: " + total);
        }

        
    }
}
