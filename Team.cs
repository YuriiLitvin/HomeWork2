namespace BuildingHouse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // team is nothing without personnel, and it should be inner property
    // this property could be set in the constructor and used internally
    // if you want to use TeamCreator -- do it, but here internally
    class Team
    {
        public static int LeaderCount { get; set; }

        public static int BuilderCount { get; set; }

        public TeamCreater Personnel { get; set; } = new TeamCreater(LeaderCount, BuilderCount);

        public Team(int leaderCount, int builderCount)
        {
            LeaderCount = leaderCount;
            BuilderCount = builderCount;
        }

        public void GetToWork(Dictionary<int, IPart> specification) //, TeamCreater personnel)
        {
            //var workers = personnel.CreateTeam();

            var partIndex = 0;
            while (partIndex < specification.Count)
            {
                foreach (KeyValuePair<int, Worker> worker in workers)
                {
                    var isDone = worker.Value.TryDoWork(specification, partIndex);

                    if (isDone)
                    {
                        partIndex++;
                    }
                }
            }

            var teamLeader = workers.Values.
                        First(x => x.Position.Contains(nameof(TeamLeader)));

            while (true)
            {
                var finishReport = teamLeader.TryDoWork(specification, partIndex);
                if (finishReport)
                {
                    break;
                }
            }
        }
    }
}
