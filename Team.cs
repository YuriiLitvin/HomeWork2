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
                foreach (var worker in workers)
                {
                    var isDone = worker.TryDoWork(plan);

                    if (isDone)
                    {
                        partIndex++;
                    }
                    if (partIndex==plan.Specification.Count)
                    {
                        break;
                    }
                }
            }

            var teamLeader = workers.First(x => x.Position.Contains(nameof(TeamLeader)));

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
