namespace BuildingHouse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Team
    {
        public TeamCreater Personnel { get; set; } = new TeamCreater();

        public void GetToWork(Dictionary<int, IPart> specification) 
        {
            var workers = this.Personnel.Team;

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
