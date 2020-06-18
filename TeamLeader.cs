using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class TeamLeader : Worker
    {
        //public string Name { get; set; }
        //public string Position { get; set; }
        //public int Energy { get; set; } 

        public override bool DoWork(Dictionary<int, IPart> specification, int partIndex)
        {
            float totalPercent = 0;
            float partPercent = 100 / specification.Count;

            // try to use LINQ .Aggregate function to count percentage
            // it will be hard, but awesome!
            var competedParts = specification.Where(pair => pair.Value.IsDone == true)
                                         .Select(pair => pair.Value.Name);

            foreach (var part in competedParts)
            {
                Console.WriteLine($"{part} completed");
                totalPercent += partPercent;
            }

            Console.WriteLine($"Construction completed: {totalPercent}%\n");
            // make from everything above method "ReportProgress"
            return false;
        }

        //public bool GetDayOff()
        //{
        //    Console.WriteLine("I can't work now. I need day off");
        //    return false;
        //}
    }
}
