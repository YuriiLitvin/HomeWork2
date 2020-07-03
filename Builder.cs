using System;
using System.Collections.Generic;
using System.Linq;

namespace BuildingHouse
{
    class Builder : Worker
    {
        public override bool DoWork(Plan plan)
        {
            var partType = GetPartTypeToWorkWith();
            foreach (var part in GetUnDoneParts(plan))
            {
                if (part.GetType() == partType)
                {
                    Construct(part);
                    RemoveCompeletedPartType(plan, partType);
                    return true;
                }
                else
                {
                    GetDenied(part, partType);
                }
            }
            return false;  
        }

        private static Type GetPartTypeToWorkWith()
        {
            var partTypesWithIndexes = Plan.PartTypesWithIndexes;
            
            var partType = partTypesWithIndexes.Select(_ => _.Key).First();
            
            return partType;
        }
        
        private static IEnumerable<IPart> GetUnDoneParts(Plan plan)
        {
            var unDoneParts = plan.Specification.Where(_ => _.IsDone == false).ToList(); 
                                               
            return unDoneParts;
        }
       
        private static void RemoveCompeletedPartType(Plan plan, Type partType)
        {
            if (plan.Specification.Where(_ => _.GetType() == partType).All(_ => _.IsDone))
            {
                Plan.PartTypesWithIndexes.Remove(partType);
            }
        }
        private static void Construct(IPart part)
        {
            Console.WriteLine($"**************I completed {part.Name}\n");
            part.IsDone = true;
        }
        private static void GetDenied(IPart part, Type partType)
        {
            Console.WriteLine($"I can't do {part.Name}" +
                    $" because {partType.Name}s are not completed");
            part.IsDone = false;
        }

    }
}
