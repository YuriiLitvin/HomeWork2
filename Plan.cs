namespace BuildingHouse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Plan
    {
        //private const int BasementCount = 1;
        //private const int WallCount = 4;
        //private const int DoorCount = 1;
        //private const int WindowCount = 4;
        //private const int RoofCount = 1;


        public List<IPart> Specification { get; }

        public static Dictionary<Type, int> PartTypesWithIndexes { get; set; } = new Dictionary<Type, int>
        {
            { typeof(Basement), 0 },
            { typeof(Wall), 1 },
            { typeof(Door), 2 },
            { typeof(Window), 3 },
            { typeof(Roof), 4 },
        };

        public Plan()
        {
            this.Specification = this.CreateSpecification();
        }

        public List<IPart> CreateSpecification()
        {
            var constructionList = this.CreateConstructions();

            return Randomizer<IPart>.GetUnsorted(constructionList);
        }

        private List<IPart> CreateConstructions()
        {
            var housePartTypes = PartTypesWithIndexes.Select(_ => _.Key);

            var constructionList = new List<IPart>();
            foreach (var part in housePartTypes)
            {
                foreach (var item in this.CreateParts(part))
                {
                    constructionList.Add(item);
                }
            }

            return constructionList;
        }

        private List<IPart> CreateParts(Type partType)
        {
            var parts = new List<IPart> 
            {
                new Basement(),
                new Wall(),
                new Wall(),
                new Wall(),
                new Wall(),
                new Door(),
                new Window(),
                new Window(), 
                new Window(),
                new Window(),
                new Roof()
            };

            var partCount = parts.Where(_ => _.GetType() == partType).Count();

            for (int i = 1; i <= partCount; i++)
            {
                var createdPart = this.CreatePart(partType);

                createdPart.Name = partType.Name + i;
                createdPart.IsDone = false;
                parts.Add(createdPart);
            }

            return parts;
        }

        private IPart CreatePart(Type partType)
        {
            return Activator.CreateInstance(partType) as IPart;
        }
    }
}
