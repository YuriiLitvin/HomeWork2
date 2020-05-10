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
            Team myTeam = new Team(1, 5);
            List<Builder> builders = myTeam.GetBuilders();
            var plan = myPlan.Get();
            List<string> constructionPlan = new List<string>(); 

            for (int i = 0; i < plan.Count; i++)
            {
                for (int j = 0; j < plan[i].PartCount; j++)
                {
                    constructionPlan.Add($"{plan[i].Name}#{j+1}");
                }

            }
            for (int i = 0; i < constructionPlan.Count; i++)
            {
                double j = i / builders.Count;
                int t = Convert.ToInt32(Math.Round(j, 0));
                
                Console.WriteLine($"{builders[i - t * builders.Count].Name} " +
                     $"{builders[i - t * builders.Count].Position}");

                Console.WriteLine($"I do {constructionPlan[i]}\n");

            }
            Console.ReadKey();

        }
    }
}
