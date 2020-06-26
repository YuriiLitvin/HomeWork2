using System;
using System.Linq;

namespace BuildingHouse
{
    class TeamLeader : Worker
    {
        public override bool DoWork(Plan plan)
        {
            var totalPercent = 0.0f;
            var partPercent = 100.0f / plan.Specification.Count;

            // try to use LINQ .Aggregate function to count percentage
            // it will be hard, but awesome!
            var completedParts = plan.Specification.Where(_ => _.IsDone).ToList();

            foreach (var part in completedParts)
            {
                Console.WriteLine($"{part} completed");
                totalPercent += partPercent;
            }

            Console.WriteLine($"Construction completed: {totalPercent}%\n");

            // make from everything above method "ReportProgress"
            return plan.Specification.All(_ => _.IsDone);
        }
    }
}
