using System;
using System.Linq;

namespace BuildingHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Team myTeam = new Team();
            Plan plan = new Plan();

            // if team will own personnel, and house will own plan
            // this will look like myTeam.GetToWork(house);
            myTeam.GetToWork(plan.Specification);

            Console.ReadKey();
        }
    }
}
