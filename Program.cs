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


            //Team myTeam = new Team(1,5);
            //var builders = myTeam.GetBuilders();
            //while (true)
            //{
            //    for (int i = 0; i < builders.Count; i++)
            //    {
            //        builders[i].DoWork(myTeam.GetConstructionPlan());
            //    }

            //}

            Builder builder = new Builder();
            builder.DoWork();

            Console.ReadKey();
        }
    }
}
