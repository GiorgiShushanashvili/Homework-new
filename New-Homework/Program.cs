using System;

namespace New_Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            

            var bank = new Bank();
            Console.WriteLine("enter 0 or 1: ");
            bank.m = int.Parse(Console.ReadLine());
            bank.CheckUserHstory();
            if (bank.ischecked)
            {
                Console.WriteLine("enter for how many months length you want a debt:");
                bank.n = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the quantity of loan: ");
                bank.loan = double.Parse(Console.ReadLine());
                bank.CalculateLoanPercnt(bank.n, bank.loan / bank.n);


            }
            else
            {
                Console.WriteLine("you are in a black list");
            }

            var microfinance = new Microfinance();
            microfinance.CheckUserHstory();
            if (microfinance.ischecked)
            {
                Console.WriteLine("enter for how many months length you want a debt:");
                microfinance.m = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the quantity of loan: ");
                microfinance.loan = double.Parse(Console.ReadLine());
                microfinance.CalculateLoanPercnt(microfinance.m, microfinance.loan / microfinance.m);
            }

            Console.ReadLine();

            












        }
    }
}

