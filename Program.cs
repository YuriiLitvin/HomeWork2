using System;

namespace BuildingHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamCreater personnel = new TeamCreater(3,4);
            Team myTeam = new Team();            
            Plan plan = new Plan(); 

            // if team will own personnel, and house will own plan
            // this will look like myTeam.GetToWork(house);
            myTeam.GetToWork(plan, personnel);

            Console.ReadKey();
        }
    }
}
