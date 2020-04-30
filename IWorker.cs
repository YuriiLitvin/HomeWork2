using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    interface IWorker
    {
        string Name { get; set; }
        string Position { get; set; }

        void DoWork();
    
    }
}
