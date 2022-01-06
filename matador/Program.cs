using System;

namespace matador
{
    class Program
    {
        static void Main(string[] args)
        {
            Die die = new Die();
            Matador matador = new Matador();

            Player player = new Player("Lasse");
            matador.addPlayer(player);
            Player player2 = new Player("Simon");
            matador.addPlayer(player2);

            matador.removePlayer(player);
            matador.start();
            

        }
    }
}
