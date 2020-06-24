using System;
using System.Collections.Generic;
using System.Linq;

namespace BuildingHouse
{
    class Builder : Worker
    {
        public override bool DoWork(Dictionary<int, IPart> specification)
        {

            foreach (KeyValuePair<int, IPart> pair in specification)
            {
                var part = pair.Value;
                if (part.IsDone)
                {
                    // go to the next part
                    
                }
                else
                {
                    CheckIfCanBeDone(part);
                    
                }
            }

            return false;
        }
        private bool CheckIfCanBeDone(IPart part)
        {
            var plan = new Plan();
            var typePart = plan.GetHousePartTypesWithIndexes().Where(_=>_.Value == 0).Select(_=>_.Key);

            if (typePart.GetType() == typeof(part))
            {
                Construct(part);
            }
            else
            {
                Console.WriteLine($"I can't do {part.Name}" +
                    $" because {typeof(IPart)} is not completed");
            }
            return false;
        }
        
        private bool Construct(IPart part)
        {
            Console.WriteLine($"**************I completed {part.Name}\n");
            part.IsDone = true;
            return part.IsDone;
        }
    
    
    }
}
