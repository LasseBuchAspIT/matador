using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspit.BasicOop.Game
{
    class GameController
    {
        private List<Player> players = new List<Player>();
        private Die die = new Die();

        public GameController(int playerCount)
        {
            for(int i = 0; i < playerCount; i++)
            {
                Player p = new Player($"Spiller{i + 1}");
                players.Add(p);
            }
        }
        

        public void PlayGame()
        {
            Player winner;
            winner = players[0];
            foreach(Player p in players)
            {
                Console.WriteLine($"{p.name}'s tur\nTryk for at starte: ");
                Console.ReadKey();
                for(int i = 0; i < 5; i++)
                {
                    die.Roll();
                    p.score += die.value;
                    Console.WriteLine(die.ToString());
                    Console.WriteLine("\n------------------------------------------\n");
                    System.Threading.Thread.Sleep(1000);
                }
                if(p.score > winner.score)
                {
                    winner = p;
                }
                Console.WriteLine($"{p.name} fik {p.score} point!");
            }
            Console.WriteLine(winner.name + " Vandt med " + winner.score + " point!");
        }

    }
}
