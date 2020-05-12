using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Plan
    {
        private readonly IPart basement = new Basement(1, 0);//,false);
        private readonly IPart wall = new Wall(4,1);//,false);
        private readonly IPart door = new Door(1,2);//,false);
        private readonly IPart window = new Window(4,3);//,false);
        private readonly IPart roof = new Roof(1,4);//,false);




        public List<IPart> GetHouseParts()
        {
            List<IPart> List = new List<IPart>
            {
                door,
                window,
                roof,
                wall,
                basement

            };
            return List;
        }


    }
}
