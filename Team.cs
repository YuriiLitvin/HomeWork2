using System;
using System.Collections.Generic;
using System.Linq;


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

        public List<IWorker> CreateLeaders()
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
        public List<IWorker> CreateBuilders()
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

        public Dictionary<int,IWorker> CreateTeam()
        {
            Randomizer<IWorker> randomizer = new Randomizer<IWorker>();
            List<IWorker> workers = CreateLeaders().Concat(CreateBuilders()).ToList();
            return randomizer.GetUnsorted(workers);
        }
        
        public void GetToWork(Plan myPlan)
        {
            Dictionary<int,IWorker> workers = this.CreateTeam();
            Dictionary<int, IPart> specification = myPlan.GetSpecification();
            
            int partToDoIndex = 0;

            while (partToDoIndex < specification.Count) 
            {
                foreach (KeyValuePair<int, IWorker> worker in workers)
                {
                    Console.WriteLine($"\n{worker.Value.Name} " +
                        $"{worker.Value.Position}");

                    bool isDone = (worker.Value.Energy >= 80) ?
                        worker.Value.DoWork(specification, partToDoIndex) : worker.Value.GetDayOff();
                    
                    worker.Value.Energy = EnergySetter.SetEnergyLevel(isDone, worker.Value.Energy);
                    
                    if (isDone) partToDoIndex++;
                    if (partToDoIndex == specification.Count)
                    {
                        GetLastReport(specification, workers);
                        break;
                    }

                }
            }       
        }
        
        public void GetLastReport(Dictionary<int, IPart> specification, Dictionary<int, IWorker> workers)
        {
            IWorker teamLeader = workers.Values.Where(x => x.Position.Contains("TeamLeader"))
                                        .First();

            int partToDoIndex = 0;
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
