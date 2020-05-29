using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Team
    {
        public int LeaderCount { get; set; }
        public int BuilderCount { get; set; }
        Random random = new Random();
        public Team(int leaderCount, int builderCount) 
        {
            //LeaderCount = Convert.ToInt32(leaderCount);
            //BuilderCount = Convert.ToInt32(builderCount);
            LeaderCount = leaderCount;
            BuilderCount = builderCount;
        }

        public List<IWorker> GetLeaders()
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
        public List<IWorker> GetBuilders()
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

        public List<IWorker> GetWorkers() => GetLeaders().Concat(GetBuilders()).ToList();

        public void GetToWork(Plan myPlan)
        {
            List<IWorker> workers = this.GetWorkers();

            Dictionary<int,IPart> specification = myPlan.GetSpecification();

            int partToDoIndex = 0;
            int builderIndex = 0;

        while (partToDoIndex < specification.Count)
            {
                Console.WriteLine($"\n{workers[builderIndex].Name} " +
                        $"{workers[builderIndex].Position}");
                
                if(workers[builderIndex].Energy >= 80)
                {
                    var isDone = workers[builderIndex].DoWork(specification, partToDoIndex);

                    if (isDone) partToDoIndex++;
                    workers[builderIndex].Energy += random.Next(5,15); 
                }
                else
                {
                    Console.WriteLine("I can't work now. I need day off");
                    workers[builderIndex].Energy += random.Next(5, 15);
                }


                builderIndex = (builderIndex + 1) % workers.Count;

                
            }

            for (int leaderIndex = 0; leaderIndex < LeaderCount; leaderIndex++)
            {
                Console.WriteLine($"\n{workers[leaderIndex].Name} " +
                     $"{workers[leaderIndex].Position}");
                workers[leaderIndex].DoWork(specification, partToDoIndex);
            }

        }
    }
}
