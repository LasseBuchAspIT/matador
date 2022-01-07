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
        public override void landed(Player p)
        {
            Console.WriteLine($"{p.Name} landed on {name}");
            if (owner == null)
            {

                Console.WriteLine("No one currently owns this property, would you like to buy it? (yes/no)\nPrice: " + price + "; Rent: " + rent + "( *1.5 per house)");
                Console.WriteLine("Your current balance is: " + p.Wallet);
                string input = Console.ReadLine().ToLower();
                while (input != "yes" && input != "no")
                {
                    Console.WriteLine("Invalid input, please try again");
                    input = Console.ReadLine();
                }
                if (input == "yes" && p.Wallet >= price)
                {
                    p.Wallet -= price;
                    owner = p;
                    Console.WriteLine($"{p.Name} bought {name}");

                }
                else if (p.Wallet < price)
                {
                    Console.WriteLine("You are too poor to buy this property");
                }
                else
                {
                    Console.WriteLine("You did not buy the property");
                }

            }
            else if(owner != p)
            {
                Console.WriteLine($"{p.Name} landed on {owner.Name}'s property");
                owner.payed(p, calculateRent());
            }
            else if(owner == p && houseAmount < 6)
            {
                string input;
                Console.WriteLine($"The property you landed on is owned by you, and does not have the max amount of houses. Do you wish to buy a house? (yes/no)\nEach house costs {houseCost}kr\nYou have {houseAmount} houses on this property, and can buy {5 - houseAmount} more");
                Console.WriteLine($"{p.Name}'s current balance is: {p.Wallet}");
                input = Console.ReadLine().ToLower();
                if(input == "yes" && p.Wallet >= houseCost)
                {
                    Console.WriteLine($"how many houses wouuld you like to buy?");
                    int houseBuyAmount;
                    bool succes = int.TryParse(Console.ReadLine(), out houseBuyAmount);
                    while (!succes && houseBuyAmount < (5 - houseAmount))
                    {
                        Console.WriteLine($"Please enter a number under {5 - houseAmount}");
                    }
                    if (houseBuyAmount * houseCost <= p.Wallet)
                    {
                        p.Wallet -= houseBuyAmount * houseCost;
                        houseAmount += houseBuyAmount;
                        Console.WriteLine($"{p.Name} bought {houseBuyAmount} house(s)");
                        Console.WriteLine($"{p.Name}'s new balance is {p.Wallet}");
                    }



                }
                else if(input == "yes")
                {
                    Console.WriteLine("You're too poor to buy a house...");
                }
                else
                {
                    Console.WriteLine("You did not buy a house.");
                }


            }
        }

        public double calculateRent()

        {
            return rent + houseCost * houseAmount;
        }

    }
}
