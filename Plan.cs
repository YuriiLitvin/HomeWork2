using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Plan
    {
        readonly IPart basement = new Basement(1);
        readonly IPart wall = new Wall(4);
        readonly IPart door = new Door(1);
        readonly IPart window = new Window(4);
        readonly IPart roof = new Roof(1);

        
        public List<IPart> Get()
        {
            List<IPart> Plan = new List<IPart>
            {
                basement, 
                wall, 
                door,
                window,
                roof 
            };
            return Plan;
        }

        public List<IPart> GetList()
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
