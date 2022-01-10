using System;

namespace matador
{
    class Program
    {
        static void Main(string[] args)
        {
            Die die = new Die();
            Matador matador = new Matador();

            Player player1 = new Player("Lasse");
            matador.addPlayer(player1);
            Player player2 = new Player("Philip");
            matador.addPlayer(player2);
            Player player3 = new Player("Asbjørn");
            matador.addPlayer(player3);
            Player player4 = new Player("Lars");
            matador.addPlayer(player4);




            matador.start();


        }
    }
}
