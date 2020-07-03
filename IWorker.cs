using System.Collections.Generic;


namespace BuildingHouse
{
    interface IWorker
    {
        string Position { get; set; }
        
        //bool DoWork(Plan plan);
        bool DoWork(House house);
        
        void GetDayOff();
    }
}
