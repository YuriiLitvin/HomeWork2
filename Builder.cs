using System;
using System.Collections.Generic;

namespace BuildingHouse
{
    class Builder : Worker
    {
        // this method does ANY part, not the one located at partToDoIndex
        // is partToDoIndex is index to start with? or is it unnecessary at all?
        // in case its index -- use specification.Skip(index)
        // otherwise -- remove
        public override bool DoWork(Dictionary<int, IPart> specification, int partToDoIndex)
        {
            // in case you don`t really need Key here (see comment above)
            // consider
            foreach (KeyValuePair<int, IPart> pair in specification)
            {
                var part = pair.Value;
                if (pair.Key == partToDoIndex && !part.IsDone)
                {
                    Console.WriteLine($"**************I completed {part.Name}\n");
                    part.IsDone = true;
                    return part.IsDone;
                }
                else if (part.IsDone)
                {
                }
                else
                {
                    Console.WriteLine($"I can't do {part.Name}" +
                        $" because {specification[partToDoIndex].Name} is not completed");
                }
            }

            return false;
        }
        
    }
}
