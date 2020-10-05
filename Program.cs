using System;
using System.Linq;

namespace BuildingHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Team myTeam = new Team();
            
            House house = new House();
            
            myTeam.GetToWork(house);

            Console.ReadKey();
        }
    }
}
