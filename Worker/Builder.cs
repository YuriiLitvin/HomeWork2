using System;
using System.Collections.Generic;
using System.Linq;

namespace BuildingHouse
{
    class Builder : Worker
    {
        public override bool DoWork(Plan plan)
        {
            var housePartType = GetPartTypeToWorkWith(plan);
            
            foreach (var housePart in GetPendingHouseParts(plan))
            {
                if (housePart.GetType() == housePartType)
                {
                    Construct(housePart);
                    RemoveCompeletedPartType(plan, housePartType);
                    return true;
                }
                else
                {
                    GetDenied(housePart, housePartType);
                }
            }
            return false;  
        }

        private static Type GetPartTypeToWorkWith(Plan plan)
        {
            return plan.ConstructionOrderWithCounts.Select(t => t.Key).FirstOrDefault();
        }

        
        private static List<IPart> GetPendingHouseParts(Plan plan)
        {
            return plan.Specification.Where(_ => _.IsDone == false).ToList(); 
            
        }
       
        private static void RemoveCompeletedPartType(Plan plan, Type partType)
        {
            if (plan.Specification.Where(_ => _.GetType() == partType).All(_ => _.IsDone))
            {
                plan.ConstructionOrderWithCounts.Remove(partType);
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
