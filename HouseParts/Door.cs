using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Door: IPart
    {
        public string Name { get; set; } = "Door";
        public int PartCount { get; set; }
        public bool IsDone { get; set; } = false;
        public int IndexBuild { get; set; } = 2;

        public Door(int partCount)
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
