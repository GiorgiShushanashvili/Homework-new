using System;
namespace Homework11_Patterns
{
    public interface IFurnitureFactory
    {
        public Ifurniture createchair();
        public Ifurniture createcoffeetable();
        public Ifurniture createsofa();

    }

    public class VictorianFactory : IFurnitureFactory
    {
        public Ifurniture createchair()
        {
            return new VictorianChair();
        }

        public Ifurniture createcoffeetable()
        {
            return new VictorianCoffetable();
        }

        public Ifurniture createsofa()
        {
            return new Victoriansofa();
        }
    }



    public class Modernfactory : IFurnitureFactory
    {
        public Ifurniture createchair()
        {
            return new Modernchair();
        }

        public Ifurniture createcoffeetable()
        {
            return new Moderncoffetable();
        }

        public Ifurniture createsofa()
        {
            return new Modernsofa();
        }
    }



    public class Artdecofactory : IFurnitureFactory
    {
        public Ifurniture createchair()
        {
            return new Artdecochair();
        }

        public Ifurniture createcoffeetable()
        {
            return new Artdecoctable();
        }

        public Ifurniture createsofa()
        {
            return new ArtdecoSofa();
        }
    }
}

