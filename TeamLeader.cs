using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class TeamLeader : IWorker
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public bool DoWork(IPart part)
        {
            Console.WriteLine($"I observe that {part.Name} " + 
                (part.IsDone ? "is done" : "isn't done"));

            return part.IsDone;
        }
    }
}
