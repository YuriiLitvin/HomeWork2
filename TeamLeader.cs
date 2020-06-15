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
        public int Energy { get; set; } 

        public bool DoWork(Dictionary<int, IPart> specification, int partIndex)
        {
            float totalPercent = 0.0f;
            float partPercent = 100.0f / (float)specification.Count;


            var competedParts = specification.Where(pair => pair.Value.IsDone == true)
                                         .Select(pair => pair.Value.Name);
            
            foreach (var part in competedParts)
            {
                Console.WriteLine($"{part} completed");
                totalPercent += partPercent;
            }
            
            Console.WriteLine($"Construction completed: {totalPercent}%\n");
            
            return false;
        }
        
        public bool GetDayOff()
        {
            Console.WriteLine("I can't work now. I need day off");
            return false;
        }
    }
}
