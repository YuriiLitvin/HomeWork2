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
            Team myTeam = new Team(1, 3);
            
            List<Builder> builders = myTeam.GetBuilders();
            
            List<IPart> constructionPlan = myTeam.GetConstructionPlan();
            
           
            for (int i = 0; i < constructionPlan.Count; i++)
            {
                double j = i / builders.Count;
                int t = Convert.ToInt32(Math.Round(j, 0));

                Console.WriteLine($"{builders[i - t * builders.Count].Name} " +
                     $"{builders[i - t * builders.Count].Position}");

                Console.WriteLine($"I do {constructionPlan[i].Name}\n");
            }


        }
    }
}
