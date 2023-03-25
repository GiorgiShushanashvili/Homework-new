using System;

namespace Homework11_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int style;
            do {
                Console.WriteLine("select your desired style");
                Console.WriteLine("press 1,2 or 3, 1 - for victorian, 2 - modern, 3 - artdeco");
                int.TryParse(Console.ReadLine(), out style); }
            while (style ==0||style>3);
            IFurnitureFactory factory = null;
            switch (style)
            {
                case 1:
                    factory =new VictorianFactory();
                    break;
                case 2:
                    factory = new Modernfactory();
                    break;
                case 3:
                    factory = new Artdecofactory();
                    break;
            }

            int product;
            do
            {
                Console.WriteLine("select your desired furniture");
                Console.WriteLine("press 1 - chair, 2 - table, 3 - for sofa");
                int.TryParse(Console.ReadLine(), out product);
            }
            while (product==0||product>3);
            Ifurniture furniture = null;
            switch (product)
            {
                case 1:
                    furniture = factory.createchair();
                    break;
                case 2:
                    furniture = factory.createcoffeetable();
                    break;
                case 3:
                    furniture = factory.createsofa();
                    break;
            }
            Console.WriteLine("furniture created");
            furniture.Finalchoice();

            



            Console.ReadLine();  

        }
    }

    








    






    














}

