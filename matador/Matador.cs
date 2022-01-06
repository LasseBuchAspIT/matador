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
        Property field2 = new Property("Petersmindevej", 4000, 400);
        Property field3 = new Property("Buchsvej", 4000, 400);
        Property field4 = new Property("clausvej", 4000, 400);
        Property field5 = new Property("2vej", 20, 20);
        Field field6 = new Field("halvvej");
        Field field7 = new Field("Kongevej");
        Field field8 = new Field("brooklyn");
        Field field9 = new Field("Placeholder");
        Field field10 = new Field("1");
        Field field11 = new Field("2");
        Field field12 = new Field("3");




        public void addPlayer(Player p)
        {
            players.Add(p);
        }

        public void removePlayer(Player p)
        {
            players.Remove(p);
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

                }
            }
        }


    }
}
