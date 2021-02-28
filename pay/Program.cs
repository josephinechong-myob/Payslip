using System;
namespace pay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the payslip generator\nPlease input your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please input your surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Please enter your annual salary");
            double salary = Double.Parse(Console.ReadLine());
            double grossIncome = Convert.ToInt32(Math.Floor(salary / 12));
            double incomeTax;
            if (salary > 180000)
            {
                incomeTax = Convert.ToInt32(Math.Ceiling((54232 + (salary - 180000) * 0.45) / 12));
            }
            else if (salary > 87000)
            {
                incomeTax = Convert.ToInt32(Math.Ceiling((19822 + (salary - 87000) * 0.37) / 12));
            }
            else if (salary > 37000)
            {
                incomeTax = Convert.ToInt32(Math.Ceiling((3572 + (salary - 37000) * 0.325) / 12));
            }
            else if (salary > 18200)
            {
                incomeTax = Convert.ToInt32(Math.Ceiling((salary - 18200) * 0.19) / 12);
            }
            else
            {
                incomeTax = 0;
            }
            double netIncome = grossIncome - incomeTax;
            Console.WriteLine("Please enter your super rate");
            double super = Convert.ToInt32(Math.Floor(grossIncome * ((Double.Parse(Console.ReadLine())) / 100)));
            Console.WriteLine("Please enter your payment start date");
            string startDate = Console.ReadLine();
            Console.WriteLine("Please enter your payment end date");
            string endDate = Console.ReadLine();
            Console.WriteLine($"Your payslip has been generated:\nName: {name} {surname}\nPay Period: {startDate} - {endDate}\nGross Income: {grossIncome}\nIncome Tax: {incomeTax}\nNet Income: {netIncome}\nSuper: {super}\nThank you for using MYOB!");
        }
    }
}