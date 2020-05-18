using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    interface IPart
    {
        string Name { get; set; }
        bool IsDone { get; set; }
    }
}
