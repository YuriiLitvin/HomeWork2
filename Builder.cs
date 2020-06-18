using System;
using System.Collections.Generic;

namespace BuildingHouse
{
    class Builder : Worker
    {
        //public string Name { get; set; }
        //public string Position { get; set; }
        //public int Energy { get; set; }



        // this method does ANY part, not the one located at partToDoIndex
        // is partToDoIndex is index to start with? or is it unnecessary at all?
        // in case its index -- use specification.Skip(index)
        // otherwise -- remove
        public override bool DoWork(Dictionary<int, IPart> specification, int partToDoIndex)
        {
            // in case you don`t really need Key here (see comment above)
            // consider
            foreach (KeyValuePair<int, IPart> part in specification)
            {
                // use && instead of & (its lazy and, there is lazy or (||) as well

                // you refer part.Value too much, please do:
                // var part = pair.Value;
                if (part.Key == partToDoIndex && !part.Value.IsDone)
                {
                    Console.WriteLine($"**************I completed {part.Value.Name}\n");
                    part.Value.IsDone = true;
                    return part.Value.IsDone;
                }

                else if (part.Value.IsDone)
                {
                }
                else
                {
                    Console.WriteLine($"I can't do {part.Value.Name}" +
                        $" because {specification[partToDoIndex].Name} is not completed");
                }
            }

            return false;
        }
        //public bool GetDayOff()
        //{
        //    Console.WriteLine("I can't work now. I need day off");
        //    return false;
        //}

    }
}
