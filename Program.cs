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
            Team myTeam = new Team(3,3);
            Plan plan = new Plan(); 
            myTeam.GetToWork(plan);

            Console.ReadKey();
        }
    }
}
