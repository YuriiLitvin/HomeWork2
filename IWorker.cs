using System.Collections.Generic;


namespace BuildingHouse
{
    interface IWorker
    {
        string Name { get; set; }

        string Position { get; set; }
        
        bool DoWork(Plan plan);
        
        void GetDayOff();
    }
}
