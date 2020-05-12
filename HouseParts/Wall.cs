using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Wall: IPart
    {
        public string Name { get; set; } 
        public int PartCount { get; set; }
        public bool IsDone { get; set; }
        public int IndexBuild { get; set; }

        public Wall(int partCount, int indexBuild)//, bool isDone)
        {
            PartCount = partCount;
            IndexBuild = indexBuild;
            //IsDone = isDone;
        }

        public List<IPart> GetParts()
        {
            List<IPart> walls = new List<IPart>();

            for (int i = 1; i <= PartCount; i++)
            {
                walls.Add(new Wall(4,1)//,false)
                {
                    Name = "Wall" + i,
                    //PartCount = 4,
                    ////IndexBuild = 1,
                    IsDone = false
                });
            }
            return walls;
        }
    }
}
