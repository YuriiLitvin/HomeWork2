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

            foreach (KeyValuePair<int, IPart> pair in specification)
            {
                if (pair.Value.IsDone)
                {
                    Console.WriteLine($"{pair.Value.Name} completed");
                    totalPercent += partPercent;
                }
            }
            Console.WriteLine($"Construction completed: {totalPercent}%\n");


            return specification.All(pair => pair.Value.IsDone == true);
        }
        
        public bool GetDayOff()
        {
            Console.WriteLine("I can't work now. I need day off");
            return false;
        }

       

    }
}
