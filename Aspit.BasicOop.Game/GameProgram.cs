using System;

namespace Aspit.BasicOop.Game
{
    class GameProgram
    {
        static void Main(string[] args)
        {
            Die d = new Die();
            DateTime dt = DateTime.Now;
            GameController gameController = new GameController(5);




            /*
            int rolls = 0;
            while(dt.Hour < 15)
            {
                dt = DateTime.Now;
                if (dt.Second % 2 == 1 && rolls == 0)
                {
                    d.Roll();
                    Console.WriteLine(d.ToString());
                    rolls++;
                    Console.WriteLine("\n----------------------------------------\n");
                }
                else if(dt.Second % 2 == 0)
                {
                    rolls = 0;
                }
                

            }
            */


            gameController.PlayGame();
            

        }



    }
}
