using System;

namespace Design_patterns_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor actor = new MainActor();
            actor.Duty();

            Duplicate duplicate = new Duplicate();
            duplicate.Duty();

            Console.ReadLine();


        }
        public abstract class Actor
        {
            public abstract void Duty();
        }
        public class MainActor : Actor
        {
            public override void Duty()
            {
                Console.WriteLine("My duty is to act in standard scenes");
            }
        }
        public class Duplicate : Actor
        {
            MainActor maincactor;
            public override void Duty()
            {
                if (maincactor == null)

                    maincactor = new MainActor();
                maincactor.Duty();
                Console.WriteLine("i also play in extremal scenes");
            }
        }
    }
}

