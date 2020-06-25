namespace BuildingHouse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Team
    {
        public TeamCreater Personnel { get; set; } = new TeamCreater();

        public void GetToWork(Plan plan) 
        {
            var workers = this.Personnel.Team;

            var partIndex = 0;
            while (partIndex < plan.Specification.Count)
            {
                foreach (KeyValuePair<int, Worker> worker in workers)
                {
                    var isDone = worker.Value.TryDoWork(plan);

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
                var finishReport = teamLeader.TryDoWork(plan);
                if (finishReport)
                {
                    break;
                }
            }
        }
    }
}
