using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Window: IPart
    {
        public string Name { get; set; } 
        public int PartCount { get; set; }
        public bool IsDone { get; set; }
        public int IndexBuild { get; set; }

        public Window(int partCount, int indexBuild)//, bool isDone)
        {
            PartCount = partCount;
            IndexBuild = indexBuild;
            //IsDone = isDone;
        }


        public List<IPart> GetParts()
        {
            List<IPart> windows = new List<IPart>();

            for (int i = 1; i <= PartCount; i++)
            {
                windows.Add(new Window(4,3)//,false)
                {
                    Name = "Window" + i,
                    //PartCount = 4,
                    ////IndexBuild = 3,
                    IsDone = false
                });
            }
            return windows;
        }
    }
}
