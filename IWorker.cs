using System;
using System.Collections.Generic;


namespace BuildingHouse
{
    interface IWorker
    {
        string Name { get; set; }

        string Position { get; set; }
        
        //int Energy { get; set; }

        bool DoWork(Dictionary<int, IPart> specification, int partIndex);
        // it should be a void
        bool GetDayOff();
    }
}
