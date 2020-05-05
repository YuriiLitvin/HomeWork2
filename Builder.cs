using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Builder : IWorker
    {
        public string Name { get; set; }
        public string Position { get; set; } 

        public void DoWork()
        {
            throw new NotImplementedException();
        }
       
    
    }
}
