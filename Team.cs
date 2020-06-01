using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Team
    {
        public int LeaderCount { get; set; }
        public int BuilderCount { get; set; }
        readonly Random random = new Random();

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

            for (int leaderIndex = 1; leaderIndex <= LeaderCount; leaderIndex++)
            {
                leaders.Add(
                    new TeamLeader()
                    {
                        Name = "Tim #" + leaderIndex,
                        Position = "TeamLeader",
                        Energy = random.Next(80, 100)
                    });
            }
            return leaders;
        }
        public List<IWorker> GetBuilders()
        {
            List<IWorker> builders = new List<IWorker>();

            for (int leaderIndex = 1; leaderIndex <= BuilderCount; leaderIndex++)
            {
                builders.Add(
                    new Builder()
                    {
                        Name = "Worker #" + leaderIndex,
                        Position = "Builder",
                        Energy = random.Next(80, 100)
                    });
            }
            return builders;
        }

        public Dictionary<int,IWorker> GetWorkers()
        {
            Randomizer<IWorker> randomizer = new Randomizer<IWorker>();
            List<IWorker> workers = GetLeaders().Concat(GetBuilders()).ToList();
            return randomizer.Get(workers);
        }
        
        public void GetToWork(Plan myPlan)
        {
            Dictionary<int,IWorker> workers = this.GetWorkers();

            Dictionary<int, IPart> specification = myPlan.GetSpecification();
            
            int partToDoIndex = 0;
            
            do
            {
                foreach (KeyValuePair<int, IWorker> worker in workers)
                {
                    Console.WriteLine($"\n{worker.Value.Name} " +
                        $"{worker.Value.Position}");
                    
                    bool isDone = worker.Value.DoWork(specification, partToDoIndex);
                    if (isDone) partToDoIndex++;

                }

            } while (partToDoIndex != specification.Count);

            IWorker teamLeader = workers.Values.Where(x => x.Position.Contains("TeamLeader"))
                            .First();
            //TODO: substitute condition "true" with something else
            while (true)
            {
                Console.WriteLine($"\n{teamLeader.Name} " +
                $"{teamLeader.Position}");

                bool finishReport = teamLeader.DoWork(specification, partToDoIndex);
                if (finishReport) break;
            }








            


        }
    }
}
