namespace BuildingHouse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Plan
    {
        //public List<IPart> House { get; }
        public List<IPart> Specification { get; }
        
        private static readonly List<IPart> parts = new List<IPart>
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
            //this.House = this.CreateSpecification();
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
            var createdParts = new List<IPart>();
            
            var partCount = parts.Where(_ => _.GetType() == partType).Count();

            for (int i = 1; i <= partCount; i++)
            {
                var createdPart = this.CreatePart(partType);

                createdPart.Name = partType.Name + i;
                createdPart.IsDone = false;
                createdParts.Add(createdPart);
            }

            return createdParts;
        }

        private IPart CreatePart(Type partType)
        {
            return Activator.CreateInstance(partType) as IPart;
        }
    }
}
