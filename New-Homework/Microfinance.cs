using System;
namespace New_Homework
{
	public class Microfinance:IFinanceoperations
	{
        public bool ischecked = true;
        private double percent = 0.1;
        private double commision = 4;
        public double loan { get; set; }
        public int m { get; set; }
        public double sum { get; set; }
        public double wholesum { get; set; }


        public void CheckUserHstory()
        {
            Console.WriteLine(ischecked);
        }


        public void CalculateLoanPercnt(int month, double amountpermonth)
        {
            month = m;
            amountpermonth = loan / m;

            sum = (loan * percent + loan) / m + commision;
            Console.WriteLine($"the sum you have to pay each month is {sum}");
            wholesum = sum * month;
            Console.WriteLine($"whole sum you should pay during loan period is {wholesum}");


        }
    }
}

