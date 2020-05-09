using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Builder : IWorker
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public void DoWork()
        {
            Plan myPlan = new Plan();
            Team myTeam = new Team(1, 3);
            List<Builder> builders = myTeam.GetBuilders();

            for (int i = 0; i < myPlan.GetConstruction().Count; i++)
            {

                for (int j = 0; j < myPlan.GetConstruction()[i].PartCount; j++)
                {
                    double value = (i + j) / builders.Count;
                    int t = Convert.ToInt32(Math.Round(value, 0));
                    
                    Console.WriteLine($"{builders[i + j - t * builders.Count].Name} " +
                        $"{builders[i + j - t * builders.Count].Position}");

                    Console.WriteLine($"I do {myPlan.GetConstruction()[i].Name}#{j+1}\n"); 
                }
            }

            Console.ReadKey();

        }
    }
}
