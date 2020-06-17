using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamCreator personnel = new TeamCreator(3,4);
            Team myTeam = new Team();            
            Plan plan = new Plan(); 

            // if team will own personnel, and house will own plan
            // this will look like myTeam.GetToWork(house);
            myTeam.GetConstructionDone(plan, personnel);

            Console.ReadKey();
        }
    }
}
