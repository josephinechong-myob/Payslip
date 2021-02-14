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

            Console.WriteLine(welcomeMessage);
            Console.WriteLine(getName);
            string name = Console.ReadLine();
            Console.WriteLine(getSurname);
            string surname = Console.ReadLine();
            Console.WriteLine(getAnnualSalary);
            string salary = Console.ReadLine();
            Console.WriteLine(getSuperRate);
            string super = Console.ReadLine();
            Console.WriteLine(getStartDate);
            string startDate = Console.ReadLine();
            Console.WriteLine(getEndDate);
            string endDate = Console.ReadLine();

            Console.WriteLine("Your payslip has been generated:");
            Console.WriteLine("Name: " + name + surname);
            Console.WriteLine("Pay Period: " + startDate + " - " + endDate);
            Console.WriteLine("Gross Income: TBD " + salary);
            Console.WriteLine("Income Tax: TBD " + salary);
            Console.WriteLine("Net Income: TBD " + salary);
            Console.WriteLine("Super: TBD " + super);
        }
    }
}
