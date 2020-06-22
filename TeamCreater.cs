using System;
using System.Collections.Generic;
using System.Linq;


namespace BuildingHouse
{
    class TeamCreater
    {
        public Dictionary<int, Worker> Team { get; set; }

        private int LeaderCount { get; set; }

        private int BuilderCount { get; set; }

        public TeamCreater()
        {
            this.LeaderCount = this.GetWorkerCount("TeamLeader");
            this.BuilderCount = this.GetWorkerCount("Builder");
            this.Team = this.CreateTeam();
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

        private int GetWorkerCount(string workerPosition)
        {
            Console.WriteLine($"Please enter a number of {workerPosition}s");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
