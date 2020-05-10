using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class House
    {
        readonly IPart Basement = new Basement(1);
        readonly IPart Wall = new Wall(4);
        readonly IPart Door = new Door(1);
        readonly IPart Window = new Window(4);
        readonly IPart Roof = new Roof(1);
        
        public House (List<IPart> Parts)
        {
            this.Basement = Parts[3];
            this.Wall = Parts[4];
            this.Door = Parts[0];
            this.Window = Parts[2];
            this.Roof = Parts[1];
        }


        public List<IPart> GetList()
        {
            List<IPart> List = new List<IPart>
            {
                Door,
                Roof,
                Window,
                Basement,
                Wall

            };
            return List;
        }
    }
}
