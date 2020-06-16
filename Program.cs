using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamCreater personnel = new TeamCreater(3,4);
            Team myTeam = new Team();            
            Plan plan = new Plan(); 
            myTeam.GetToWork(plan, personnel);

            Console.ReadKey();
        }
    }
}
