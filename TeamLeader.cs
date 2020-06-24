using System;
using System.Collections.Generic;
using System.Linq;

namespace BuildingHouse
{
    class TeamLeader : Worker
    {
        public override bool DoWork(Dictionary<int, IPart> specification)
        {
            var totalPercent = 0.0f;
            var partPercent = 100.0f / specification.Count;

            // try to use LINQ .Aggregate function to count percentage
            // it will be hard, but awesome!
            var completedParts = specification.Where(pair => pair.Value.IsDone)
                                         .Select(pair => pair.Value.Name);

            foreach (var part in completedParts)
            {
                Console.WriteLine($"{part} completed");
                totalPercent += partPercent;
            }

            Console.WriteLine($"Construction completed: {totalPercent}%\n");

            // make from everything above method "ReportProgress"
            return specification.All(pair => pair.Value.IsDone);
        }
    }
}
