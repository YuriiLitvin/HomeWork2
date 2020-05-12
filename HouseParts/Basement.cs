using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Basement : IPart
    {
        public string Name { get; set; } 
        public int PartCount { get; set; } 
        public bool IsDone { get; set; }
        public int IndexBuild { get; set; }

        public Basement(int partCount, int indexBuild)//, bool isDone)
        {
            PartCount = partCount;
            IndexBuild = indexBuild;
            //IsDone = isDone;
        }

        public List<IPart> GetParts()
        {
            List<IPart> basements = new List<IPart>();

            for (int i = 1; i <= PartCount; i++)
            {
                basements.Add(new Basement(1,0)//,false)
                {
                    Name = "Basement" + i,
                    //PartCount = 1,
                    //IndexBuild = 0,
                    IsDone = false
                });
            }
            return basements;
        }
    }
}
