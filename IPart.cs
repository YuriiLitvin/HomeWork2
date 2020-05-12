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
        int PartCount { get; set; }
        bool IsDone { get; set; }
        int IndexBuild { get; set; }
        List<IPart> GetParts();
        
    }
}
