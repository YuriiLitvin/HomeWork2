using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Roof : IPart
    {
        public string Name { get; set; }
        public int PartCount { get; set; }
        public bool IsDone { get; set; }
        public int IndexBuild { get; set; }


        public Roof(int partCount, int indexBuild)//, bool isDone)
        {
            PartCount = partCount;
            IndexBuild = indexBuild;
            //IsDone = isDone;
        }


        public List<IPart> GetParts()
        {
            List<IPart> rooves = new List<IPart>();

            for (int i = 1; i <= PartCount; i++)
            {
                rooves.Add(new Roof(1,4)//,false)
                {
                    Name = "Roof" + i,
                    //PartCount = 1,
                    ////IndexBuild = 4,
                    IsDone = false
                });
            }
            return rooves;
        }
    }
}
