using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class TeamLeader : IWorker
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public bool DoWork(List<IPart> list)
        {
            float totalPercent = 0.0f;
            float partPercent = 100 / list.Count;
            
            foreach (var part in list)
            {
                if (part.IsDone)
                {
                    Console.WriteLine($"{part.Name} completed");
                    totalPercent += partPercent;
                }
            }
            Console.WriteLine($"Construction completed: {totalPercent}%\n");
            return false;
        }
    }
}
