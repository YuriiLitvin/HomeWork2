using System;
using System.Collections.Generic;
using System.Linq;

namespace BuildingHouse
{
    class Builder : Worker
    {
        public override bool DoWork(Plan plan)
        {
            var partTypesWithIndexes = Plan.PartTypesWithIndexes;

            var partType = partTypesWithIndexes.OrderBy(_ => _.Value).Select(_ => _.Key).First();


            var notCompletedParts = plan.Specification
                .Where(_ => _.Value.IsDone == false && _.Value.GetType() == partType)
                .Select(_ => _.Value);

            foreach (var part in notCompletedParts)
            {
                if (Construct(part)) break;
            }
            if (plan.Specification.Values.All(_ => _.GetType() == partType && _.IsDone))
            {
                partTypesWithIndexes.Remove(partType);
            }

            return true;  
        }
        //private bool CheckIfCanBeDone(IPart part)
        //{
            

        //    var plan = new Plan();
        //    var partType = plan.GetHousePartTypesWithIndexes()
        //                       .Where(_ => _.Value == indexBuild)
        //                       .Select(_ => _.Key);

        //    if (partType.GetType() == typeof(part))
        //    {
        //        Construct(part);
        //    }
        //    else
        //    {
        //        Console.WriteLine($"I can't do {part.Name}" +
        //            $" because {typeof(IPart)} is not completed");
        //    }
        //    return false;
        //}
        
        private bool Construct(IPart part)
        {
            Console.WriteLine($"**************I completed {part.Name}\n");
            part.IsDone = true;
            return part.IsDone;
        }
    
    
    }
}
