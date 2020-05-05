using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Plan
    {
        readonly IPart basement = new Basement();
        readonly IPart wall1 = new Wall();
        readonly IPart wall2 = new Wall();
        readonly IPart wall3 = new Wall();
        readonly IPart wall4 = new Wall();
        readonly IPart door = new Door();
        readonly IPart window1 = new Window();
        readonly IPart window2 = new Window();
        readonly IPart window3 = new Window();
        readonly IPart window4 = new Window();
        readonly IPart roof = new Roof();


        public List<IPart> GetStructured()
        {
            List<IPart> BuildingPlan = new List<IPart>
            {
                basement,
                wall1,
                wall2,
                wall3,
                wall4,
                door,
                window1,
                window2,
                window3,
                window4,
                roof
            };
            return BuildingPlan;
        }

        public List<IPart> GetListOfParts()
        {
            List<IPart> ListOfParts = new List<IPart>
            {
                door,
                wall1,
                roof,
                window4,
                wall4,
                window1,
                window2,
                basement,
                wall3,
                window3,
                wall2
                
            };
            return ListOfParts;
        }
    }
}
