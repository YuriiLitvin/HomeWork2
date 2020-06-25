using System;
using System.Collections.Generic;
using System.Linq;

namespace BuildingHouse
{
    class Builder : Worker
    {
        public Plan Plan { get; set; } = new Plan();
        
        public override bool DoWork(Dictionary<int, IPart> specification)
        {
            var partTypes = Plan.PartTypesWithIndexes;

            var typePart = partTypes.OrderBy(_ => _.Value).Select(_ => _.Key).First();


            var notCompletedParts = specification
                .Where(_ => _.Value.IsDone == false && _.Value.GetType() == typePart)
                .Select(_ => _.Value);

            foreach (var part in notCompletedParts)
            {
                if (Construct(part)) break;
            }

            return true;  
        }
        //private bool CheckIfCanBeDone(IPart part)
        //{
            

        //    var plan = new Plan();
        //    var typePart = plan.GetHousePartTypesWithIndexes()
        //                       .Where(_ => _.Value == indexBuild)
        //                       .Select(_ => _.Key);

        //    if (typePart.GetType() == typeof(part))
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
