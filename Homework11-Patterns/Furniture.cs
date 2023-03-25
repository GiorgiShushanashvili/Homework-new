using System;
namespace Homework11_Patterns
{
    public interface Ifurniture
    {
        void Finalchoice();
    }

    public class VictorianChair : Ifurniture
    {
        public void Finalchoice()
        {
            Console.WriteLine($"chosen product is {this}");
        }
    }
    public class Modernchair : Ifurniture
    {
        public void Finalchoice()
        {
            Console.WriteLine($"chosen product is {this}");
        }
    }
    public class Artdecochair : Ifurniture
    {
        public void Finalchoice()
        {
            Console.WriteLine($"chosen product is {this}");
        }
    }


    public class VictorianCoffetable : Ifurniture
    {
        public void Finalchoice()
        {
            Console.WriteLine($"chosen product is {this}");
        }
    }
    public class Moderncoffetable : Ifurniture
    {
        public void Finalchoice()
        {
            Console.WriteLine($"chosen product is {this}");
        }
    }
    public class Artdecoctable : Ifurniture
    {
        public void Finalchoice()
        {
            Console.WriteLine($"chosen product is {this}");
        }
    }



    public class Victoriansofa : Ifurniture
    {
        public void Finalchoice()
        {
            Console.WriteLine($"chosen product is {this}");
        }
    }

    public class Modernsofa : Ifurniture
    {
        public void Finalchoice()
        {
            Console.WriteLine($"chosen product is {this}");
        }
    }

    public class ArtdecoSofa : Ifurniture
    {
        public void Finalchoice()
        {
            Console.WriteLine($"chosen product is {this}");
        }
    }
}

