namespace BuildingHouse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Plan
    {
       //public List<IPart> Specification { get; }

        public static List<IPart> parts = new List<IPart>
        {
            new Wall(),
            new Window(),
            new Roof(),
            new Window(),
            new Door(),
            new Wall(),
            new Window(),
            new Wall(),
            new Basement(),
            new Wall(),
            new Window()
        };
        
        
        public static Dictionary<Type, int> PartTypesWithIndexes { get; set; } = new Dictionary<Type, int>
        {
            { typeof(Roof), 4 },
            { typeof(Door), 2 },
            { typeof(Basement), 0 },
            { typeof(Window), 3 },
            { typeof(Wall), 1 },
        };

        //public Plan()
        //{
        //    this.Specification = this.CreateSpecification();
        //}
        
        //public List<IPart> CreateSpecification()
        //{
        //    var constructionList = this.CreateConstructions();

        //    return Randomizer<IPart>.GetUnsorted(constructionList);
        //}

        //private List<IPart> CreateConstructions()
        //{
        //    var housePartTypes = PartTypesWithIndexes
        //        .OrderBy(_ => _.Value)
        //        .Select(_ => _.Key);

        //    var constructionList = new List<IPart>();
        //    foreach (var part in housePartTypes)
        //    {
        //        Console.WriteLine($"Please enter a number of {part.Name}s");
        //        var partCount = Convert.ToInt32(Console.ReadLine());
        //        foreach (var item in this.CreateParts(part, partCount))
        //        {
        //            constructionList.Add(item);
        //        }
        //    }

        //    return constructionList;
        //}

        //private List<IPart> CreateParts(Type partType, int partCount)
        //{
        //    var parts = new List<IPart>();

        //    for (int i = 1; i <= partCount; i++)
        //    {
        //        var createdPart = this.CreatePart(partType);

        //        createdPart.Name = partType.Name + i;
        //        createdPart.IsDone = false;
        //        parts.Add(createdPart);
        //    }

        //    return parts;
        //}

        //private IPart CreatePart(Type partType)
        //{
        //    return Activator.CreateInstance(partType) as IPart;
        //}
    }
}
