using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matador
{
    class Player
    {
        public List<Field> ownedFields = new List<Field>();

        private string name;
        private double wallet = 10000;
        private int fieldNumber = 0;

        public string Name { get => name; }
        public double Wallet { get => wallet; set => wallet = value; }
        public int FieldNumber { get => fieldNumber; set => fieldNumber = value; }

        public Player(string playerName)
        {
            name = playerName;
        }

        public void payed(Player giver, double amount)
        {
            if(giver.Wallet >= amount)
            {
                giver.pay(amount);
                wallet += amount;
                Console.WriteLine($"{giver.Name} paid {amount}kr. to {name}");
                Console.WriteLine($"{giver.name}'s balance is now: {giver.Wallet}\n{name}'s balance is now: {Wallet}");
            }
            else
            {
                Console.WriteLine($"{giver.Name} has run out of money and has therefore lost...");
                wallet += amount;
                giver.wallet = -10000000;
                foreach(Property f in ownedFields)
                {
                    f.removeOwner();
                }

            }
        }

        public void pay(double amount)
        {
            wallet -= amount;
        }

        public void addProperty(Property p)
        {
            ownedFields.Add(p);
        }

    }
}
