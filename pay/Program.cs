using System;

namespace pay
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcomeMessage = "Welcome to the payslip generator";
            string getName = "Please input your name";
            string getSurname = "Please input your surname";
            string getAnnualSalary = "Please enter your annual salary";
            string getSuperRate = "Please enter your super rate";
            string getStartDate = "Please enter your payment start date";
            string getEndDate = "Please enter your payment end date";
            string name;
            string surname;
            double salary;
            double super;
            string startDate;
            string endDate;
            double grossIncome;
            double netIncome;
            double incomeTax;
            double calculatedSuper;

            // Console.WriteLine(welcomeMessage,getName);
            Console.WriteLine(welcomeMessage);
            Console.WriteLine(getName);
            name = Console.ReadLine();
            Console.WriteLine(getSurname);
            surname = Console.ReadLine();
            Console.WriteLine(getAnnualSalary);
            salary = Double.Parse(Console.ReadLine());

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

            Console.WriteLine(getSuperRate);
            super = Double.Parse(Console.ReadLine());
            Console.WriteLine(getStartDate);
            startDate = Console.ReadLine();
            Console.WriteLine(getEndDate);
            endDate = Console.ReadLine();

            grossIncome = Convert.ToInt32(Math.Floor(salary / 12));
            calculatedSuper = Convert.ToInt32(Math.Floor(grossIncome * (super / 100)));
            netIncome = grossIncome - incomeTax;
            
            Console.WriteLine("Your payslip has been generated:");
            Console.WriteLine("Name: " + name + " " + surname);
            Console.WriteLine("Pay Period: " + startDate + " - " + endDate);
            Console.WriteLine("Gross Income: " + grossIncome);
            Console.WriteLine("Income Tax: " + incomeTax);
            Console.WriteLine("Net Income: " + netIncome);
            Console.WriteLine("Super: " + calculatedSuper);
            Console.WriteLine("Thank you for using MYOB!");
        }
    }
}
