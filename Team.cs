using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Team
    {
        public int LeaderCount { get; set; }
        public int BuilderCount { get; set; }
        
        public Team(int leaderCount, int builderCount) 
        {
            //LeaderCount = Convert.ToInt32(leaderCount);
            //BuilderCount = Convert.ToInt32(builderCount);
            LeaderCount = leaderCount;
            BuilderCount = builderCount;
        }

        public List<IWorker> GetLeaders()
        {
            List<IWorker> leaders = new List<IWorker>();

            for (int i = 1; i <= LeaderCount; i++)
            {
                leaders.Add(
                    new TeamLeader()
                    {
                        Name = "Tim #" + i,
                        Position = "TeamLeader"
                    });
            }
            return leaders;
        }
        public List<IWorker> GetBuilders()
        {
            List<IWorker> builders = new List<IWorker>();

            for (int i = 1; i <= BuilderCount; i++)
            {
                builders.Add(
                    new Builder()
                    {
                        Name = "Worker #" + i,
                        Position = "Builder"
                    });
            }
            return builders;
        }

        public List<IWorker> GetWorkers() => GetLeaders().Concat(GetBuilders()).ToList();

        public void GetToWork(Plan myPlan)
        {
            List<IWorker> workers = this.GetWorkers();

            List<IPart> constructionPlan = myPlan.GetConstructionPlan();

            int partIndex = 0;
            int builderIndex = 0;
            while (partIndex < constructionPlan.Count)
            {
                Console.WriteLine($"{workers[builderIndex].Name} " +
                     $"{workers[builderIndex].Position}");

                var partToWorkWith = constructionPlan[partIndex];
                
                var isDone = workers[builderIndex].DoWork(partToWorkWith);
                
                if (isDone) partIndex++;
                
                builderIndex = (builderIndex + 1) % workers.Count;
            }
        }
    }
}
