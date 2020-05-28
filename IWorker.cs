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
        
        int Energy { get; set; }

        bool DoWork(Dictionary<int, IPart> specification, int partIndex);    
    }
}
