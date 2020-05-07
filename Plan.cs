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

        //public List<IPart> Parts { get; set; }
        //public string Name { get; set; }

        public List<IPart> GetConstruction()
        {
            List<IPart> ConstructionPlan = new List<IPart>
            {
                basement, 
                wall, 
                door,
                window,
                roof 
            };
            return ConstructionPlan;
        }

        public List<IPart> GetListOfParts()
        {
            List<IPart> ListOfParts = new List<IPart>
            {
                door,
                window,
                roof,
                wall,
                basement

            };
            return ListOfParts;
        }


    }
}
