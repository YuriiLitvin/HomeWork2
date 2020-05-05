using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Door: IPart
    {
        public bool Done { get; set; }

        public bool CheckIfDone()
        {
            throw new NotImplementedException();
        }
    }
}
