using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Person
    {
        private string name;
        private int age;
        private int iq;

        public string Name { get => name;}
        public int Iq { get => iq; set => iq = value; }

        public Person(string personName, int personIq)
        {
            name = personName;
            iq = personIq;
            age = 0;
        }

        public void increaseAge()
        {
            age++;
        }

        private bool isChild()
        {
            if(age < 18)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private bool isPensioner()
        {
            if(age > 67)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isMenzaner()
        {
            if(iq < 140)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
