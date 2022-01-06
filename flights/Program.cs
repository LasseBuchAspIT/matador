using System;

namespace flights
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Flight f = new Flight("a", "a", "a", 20000);
            for(int i = 0; i < 10; i++)
            {
                Luggage l = new Luggage(rnd.Next(1, 21));
                f.addLuggage(l);
            }
            f.removeLuggage();


            
        }
    }
}
