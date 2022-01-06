using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flights
{
    class Flight
    {
        private List<Luggage> luggageList = new List<Luggage>();
        private string flightNumber;
        private string departure;
        private string destination;
        private int totalLoadCapacity;

        public Flight(string flightN, string flightDepart, string flightDestination, int flightLoad)
        {
            flightNumber = flightN;
            departure = flightDepart;
            destination = flightDestination;
            totalLoadCapacity = flightLoad;
        }

        public string toString()
        {
            return $"{flightNumber}: {departure} - {destination} (C: {totalLoadCapacity}; A: {availableLoadCapacity()} kg)";
        }

        public int availableLoadCapacity()
        {
            int remainingLoadCapacity = totalLoadCapacity;
            foreach(Luggage l in luggageList)
            {
                    remainingLoadCapacity -= l.GetWeight;
            }
            return remainingLoadCapacity;
        }

        public void addLuggage(Luggage l)
        {
            if(availableLoadCapacity() - l.GetWeight > 0)
            {
                luggageList.Add(l);
            }
            else
            {
                Console.WriteLine("bagagen vejer for meget!");
            }
        }

        public void removeLuggage()
        {
            int i = 0;
            foreach(Luggage l in luggageList)
            {
                Console.WriteLine($"{i}: {l.GetWeight}kg");
                i++;
            }

            Console.WriteLine("Type the index of the luggage you want to remove: ");
            int choice = int.Parse(Console.ReadLine());
            luggageList.RemoveAt(choice);
        } 
    }
}
