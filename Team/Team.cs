namespace BuildingHouse
{
    using System.Linq;

    class Team
    {
        public TeamCreator Personnel { get; set; } = new TeamCreator();

        public void GetToWork(House house) 
        {
            var workers = this.Personnel.Team;
            var housePlan = house.Plan;
            
            var partIndex = 0;
            while (partIndex < housePlan.Specification.Count)
            {
                foreach (var worker in workers)
                {
                    var isDone = worker.TryDoWork(housePlan);

                    if (isDone)
                    {
                        partIndex++;
                    }
                    else if (partIndex== housePlan.Specification.Count)
                    {
                        break;
                    }
                }
            }

            var teamLeader = workers.First(t => t.Position.Contains(nameof(TeamLeader)));

            while (true)
            {
                var finishReport = teamLeader.TryDoWork(housePlan);
                if (finishReport)
                {
                    break;
                }
            }
        }
    }
}
