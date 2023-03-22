using System;
namespace New_Homework
{
	public class Bank:IFinanceoperations
	{
        public int m { get; set; }
        public bool ischecked;
        private double percent1 = 0.05;

        public int n { get; set; }
        public double loan { get; set; }
        public double sum { get; set; }
        public double percent { get; set; }



        public void CheckUserHstory()
        {
            switch (m)
            {
                case 0:
                    ischecked = false;
                    Console.WriteLine(ischecked);
                    break;
                case 1:
                    ischecked = true;
                    Console.WriteLine(ischecked);
                    break;
            }

        }

        public void CalculateLoanPercnt(int month, double amountpermonth)
        {
            //პირობა ცოტა ვერ გავიგე, amountpermonth ისედაც ყოვეთვიური თანხაა,
            //ჩავთვალოთ რომ amountpermonth არის ძირის თანხა, უნდა გავიგოთ მთლიანი(პროცენტით ყოველთვიური) 
            month = n;
            amountpermonth = loan / n;

            sum = loan * percent1 / month + amountpermonth;
            Console.WriteLine($"the sum you have to pay each month including percent is {sum} ");

            percent = (sum - amountpermonth) * month;
            Console.WriteLine($"whole percent you have to pay during loan period is {percent}");



        }
    }
}

