using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matador
{
    class Matador
    {
        public Die die = new Die();

        private List<Player> players = new List<Player>();
        private List<Field> fields = new List<Field>();
        
        

        Start field1 = new Start(4000);
        Gade field2 = new Gade("Bredgade", 5200, 450, 3000);
        Gade field3 = new Gade("Bernstorfsvej", 3600, 300, 2000);
        Gade field4 = new Gade("Strandvejen", 4000, 350, 2000);
        Gade field5 = new Gade("Vimmelskaftet", 6000, 550, 4000);
        Gade field6 = new Gade("Amagertorv", 6000, 550, 4000);
        Gade field7 = new Gade("Nygade", 6400, 600, 4000);
        Gade field8 = new Gade("Hellerup", 3600, 300, 2000);
        Gade field9 = new Gade("Gl. Kongevej", 3200, 250, 2000);
        Gade field10 = new Gade("Fredriksberg allé", 3600, 300, 2000);
        Gade field11 = new Gade("bülowsvej", 2800, 200, 2000);
        Gade field12 = new Gade("Kgs. Nytorv", 5200, 450, 3000);
        Gade field13 = new Gade("Østergade", 5600, 500, 3000);
        Gade field14 = new Gade("Rådhuspladsen", 8000, 1000, 4000);
        Gade field15 = new Gade("Trianglen", 4400, 350, 3000);
        Gade field16 = new Gade("Grønningen", 4800, 400, 3000);
        Gade field17 = new Gade("Rødovrevej", 1200, 50, 1000);
        Gade field18 = new Gade("Valby Langgade", 2000, 100, 1000);
        Gade field19 = new Gade("Fredriksberggade", 7000, 700, 4000);
        Gade field20 = new Gade("Østerbrogade", 4400, 350, 3000);





        public void addPlayer(Player p)
        {
            players.Add(p);
        }

        public void removePlayer(Player p)
        {
            p.Wallet = -10000000;
            players.Remove(p);
            foreach(Player pp in players)
            {
                Console.WriteLine(pp.Name);
                Console.WriteLine(pp.Wallet);
            }
        }

        public void start()
        {
            fields.Add(field1);
            fields.Add(field2);
            fields.Add(field3);
            fields.Add(field4); 
            fields.Add(field5);
            fields.Add(field6);
            fields.Add(field7);
            fields.Add(field8);
            fields.Add(field9);
            fields.Add(field10);
            fields.Add(field11);
            fields.Add(field12);
            fields.Add(field13);
            fields.Add(field14);
            fields.Add(field15);
            fields.Add(field16);
            fields.Add(field17);
            fields.Add(field18);
            fields.Add(field19);
            fields.Add(field20);

            while (true)
            {
                foreach(Player p in players) 
                {
                    die.roll();
                    Console.WriteLine($"{p.Name} rolled a {die.Value}");
                    for(int i = 0; i < die.Value - 1; i++)
                    {
                        
                        if(p.FieldNumber == fields.Count() - 1)
                        {
                            p.FieldNumber = -1;
                        }
                        p.FieldNumber++;
                        fields[p.FieldNumber].passed(p);   
                    }
                    if (p.FieldNumber == fields.Count() - 1)
                    {
                        p.FieldNumber = -1;
                    }
                    p.FieldNumber++;
                    fields[p.FieldNumber].landed(p);
                    Console.ReadKey();
                    Console.WriteLine();


                    if(p.Wallet <= 0)
                    {
                        Console.WriteLine($"{p.Name} Has lost and has therefore been removed");
                        removePlayer(p);
                        players.Remove(p);
                        break;
                    }
                }

            }
        }


    }
}
