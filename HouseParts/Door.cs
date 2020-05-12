using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Door: IPart
    {
        public string Name { get; set; } 
        public int PartCount { get; set; }
        public bool IsDone { get; set; }
        public int IndexBuild { get; set; } 

        public Door(int partCount, int indexBuild)//, bool isDone)
        {
            PartCount = partCount;
            IndexBuild = indexBuild;
            //IsDone = isDone;
        }

        public List<IPart> GetParts()
        {
            List<IPart> doors = new List<IPart>();

            for (int i = 1; i <= PartCount; i++)
            {
                doors.Add(new Door(1,2)//,false)
                {
                    Name = "Door" + i,
                    //PartCount = 1,
                    ////IndexBuild = 2,
                    IsDone = false
                });
            }
            return doors;
        }
    }
}
