using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Wall: IPart
    {
        public string Name { get; set; } = "Wall";
        public int PartCount { get; set; }
        public bool IsDone { get; set; } = false;

        public Wall(int partCount)
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
