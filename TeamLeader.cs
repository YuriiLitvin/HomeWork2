using System;
using System.Collections.Generic;
using System.Linq;


namespace BuildingHouse
{
    class TeamLeader : Worker
    {
        //public string Name { get; set; }
        //public string Position { get; set; }
        

        public bool DoWork(List<IPart> specification)
        {
            // DONE: or var x = 0.0f or float x = 0, not both!
            float totalPercent = 0;
            // DONE: float / int = float already, you don`t need to cast
            float partPercent = 100 / specification.Count;

            // try to use LINQ .Aggregate function to count percentage
            // it will be hard, but awesome!
            var competedParts = specification.Where(_ => _.IsDone == true)
                                         .Select(_ => _.Name);
            
            foreach (var part in competedParts)
            {
                Console.WriteLine($"{part} completed");
                totalPercent += partPercent;
            }
            
            Console.WriteLine($"Construction completed: {totalPercent}%\n");
            // make from everything above method "ReportProgress"
            return false;
        }

        public bool GetDayOff()
        {
            Console.WriteLine("I can't work now. I need day off");
            return false;
        }
    }
}
