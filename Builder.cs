using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

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

        private Type GetPartTypeToWorkWith()
        {
            var partTypesWithIndexes = Plan.PartTypesWithIndexes;
            var partTypeIndex = partTypesWithIndexes.Min(_ => _.Value);
            var partType = partTypesWithIndexes.Where(_ => _.Value == partTypeIndex)
                                               .Select(_ => _.Key)
                                               .First();
            return partType;
        }
        private IEnumerable<IPart> GetUnDoneParts(Plan plan)
        {
            var unDoneParts = plan.Specification.Where(_ => _.Value.IsDone == false)
                                               .Select(_ => _.Value);
            return unDoneParts;
        }
        private void RemoveCompeletedPartType(Plan plan, Type partType)
        {
            if (plan.Specification.Where(_ => _.Value.GetType() == partType).All(_ => _.Value.IsDone))
            {
                Plan.PartTypesWithIndexes.Remove(partType);
            }
        }
        private bool Construct(IPart part)
        {
            Console.WriteLine($"**************I completed {part.Name}\n");
            part.IsDone = true;
            return part.IsDone;
        }
        private bool GetDenied(IPart part, Type partType)
        {
            Console.WriteLine($"I can't do {part.Name}" +
                    $" because {partType} is not completed");
            part.IsDone = false;
            return part.IsDone;
        }

    }
}
