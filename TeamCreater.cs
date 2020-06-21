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


        public TeamCreater(int leaderCount, int builderCount)
        {
            this.LeaderCount = leaderCount;
            this.BuilderCount = builderCount;
            this.CreateTeam();
        }

        public List<Worker> CreateLeaders()
        {
            List<Worker> leaders = new List<Worker>();

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

        public List<Worker> CreateBuilders()
        {
            List<Worker> builders = new List<Worker>();

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

        public Dictionary<int, Worker> CreateTeam()
        {
            List<Worker> workers = CreateLeaders().Concat(CreateBuilders()).ToList();
            return Randomizer<Worker>.GetUnsorted(workers);
        }


    }
}
