using System;
using System.Collections.Generic;
using System.Linq;


namespace BuildingHouse
{
    // from external perspective you use this class to only call CreateTeam()
    // make a "Team" property, set it within constructor
    // replace external calls to CreateTeam() with property usage
    class TeamCreator
    {
        public int LeaderCount { get; set; }
        public int BuilderCount { get; set; }

        public TeamCreator(int leaderCount, int builderCount)
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
                    });
            }
            return builders;
        }

        public List<IWorker> CreateTeam()
        {
            List<IWorker> workers = CreateLeaders().Concat(CreateBuilders()).ToList();
            
            return Randomizer<IWorker>.GetRandomOrderList(workers);
        }


    }
}
