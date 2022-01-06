using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matador
{
    class Property : Field
    {
        protected Player owner = null;
        protected double price;
        protected double rent;

        public Property(string name, int propertyPrice, int propertyRent) : base(name)
        {
            price = propertyPrice;
            rent = propertyRent;
        }

        public virtual double BeregnLeje()
        {
            return rent;
        }

        public override void landed(Player p)
        {
            Console.WriteLine($"{p.Name} landed on {name}");
            if (owner == null)
            {
                
                Console.WriteLine("No one currently owns this property, would you like to buy it? (yes/no)\nPrice: " + price + "; Rent: " + rent + "( *1.5 per house)");
                Console.WriteLine("Your current balance is: " + p.Wallet);
                string input = Console.ReadLine().ToLower();
                while(input != "yes" && input != "no")
                {
                    Console.WriteLine("Invalid input, please try again");
                    input = Console.ReadLine();
                }
                if(input == "yes" && p.Wallet >= price)
                {
                    p.Wallet -= price;
                    owner = p;
                    Console.WriteLine($"{p.Name} bought {name}");

                }
                else if (p.Wallet < price && input == "yes")
                {
                    Console.WriteLine("You are too poor to buy this property");
                }
                else
                {
                    Console.WriteLine("You did not buy the property");
                }

            }
            else
            {
                Console.WriteLine($"{p.Name} landed on {owner.Name}'s property");
                owner.payed(p, rent);
            }
        }



    }

    
}
