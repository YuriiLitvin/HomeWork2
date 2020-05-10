using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Roof : IPart
    {
        public string Name { get; set; } = "Roof";
        public int PartCount { get; set; }
        public bool IsDone { get; set; } = false;
        public int IndexBuild { get; set; } = 4;


        public Roof(int partCount)
        {
            PartCount = partCount;
        }


        public bool CheckIfDone()
        {
            if (IsDone)
            {
                return true;
            }
            return false;
        }
    }
}
