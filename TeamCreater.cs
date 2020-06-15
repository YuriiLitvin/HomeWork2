using System;
using System.Collections.Generic;
using System.Linq;


namespace BuildingHouse
{
    // from external perspective you use this class to only call CreateTeam()
    // make a "Team" property, set it within constructor
    // replace external calls to CreateTeam() with property usage
    class TeamCreater
    {
        public int LeaderCount { get; set; }
        public int BuilderCount { get; set; }

        readonly Random random = new Random();

        public TeamCreater(int leaderCount, int builderCount)
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

        public Dictionary<int, IWorker> CreateTeam()
        {
            Randomizer<IWorker> randomizer = new Randomizer<IWorker>();
            List<IWorker> workers = CreateLeaders().Concat(CreateBuilders()).ToList();
            return randomizer.GetUnsorted(workers);
        }


    }
}
