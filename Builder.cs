using System;
using System.Collections.Generic;

namespace BuildingHouse
{
    class Builder : Worker
    {
       
        // this method does ANY pair, not the one located at partToDoIndex
        // is partToDoIndex is index to start with? or is it unnecessary at all?
        // in case its index -- use specification.Skip(index)
        // otherwise -- remove
        public bool GetToWork(List<IPart> specification)
        {
            if (Energy >= 80)
            {
                this.DoWork(specification);
            }
            else
            {
                this.GetDayOff();
            }
            return false;
        }
        
        
        
        
        
        public bool DoWork(List<IPart> specification)
        {
            // in case you don`t really need Key here (see comment above)
            // consider
            foreach (var part in specification)
            {
                // DONE: use && instead of & (its lazy and, there is lazy or (||) as well

                // DONE: you refer pair.Value too much, please do:
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
                    Console.WriteLine(
                        $"I can't do {part.Name}" +
                        $" because {specification[partToDoIndex].Name} is not completed");
                }
            }
            
            return false;
        }
        
    }
}
