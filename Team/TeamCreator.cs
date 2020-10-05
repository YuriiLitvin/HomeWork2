using System;
using System.Collections.Generic;

namespace BuildingHouse
{
    class TeamCreator
    {
        private int workerCount;

        public List<Worker> Team { get; set; }

        private readonly List<Type> workerTypes = new List<Type>
        {
            typeof(TeamLeader),
            typeof(Builder)
        };

        public TeamCreator()
        {
            this.Team = this.CreateTeam();
        }

        private List<Worker> CreateWorkers()
        {
            var workers = new List<Worker>();
            
            foreach (var workerType in workerTypes)
            {
                workerCount = GetWorkerCount(workerType.Name);

                for (int workerIndex = 1; workerIndex <= workerCount; workerIndex++)
                {
                    var worker = Activator.CreateInstance(workerType) as Worker;
                    
                    worker.Name = workerType.Name.Substring(0,2) + "# " + workerIndex;
                    worker.Position = workerType.Name;
                    workers.Add(worker);

                }
            }
            return workers;
        }


        private List<Worker> CreateTeam()
        {
            var workers = CreateWorkers();
            return Randomizer<Worker>.GetDisordered(workers);
        }

        private int GetWorkerCount(string workerPosition)
        {
            Console.WriteLine($"Please enter a number of {workerPosition}s");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
