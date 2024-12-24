// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace EmployeeWages
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeeWages emp = new EmployeeWages();
            emp.Attendance();
            emp.DailyEmployeeWage();
            emp.PartTimeEmployeeWage();
            emp.WagesPerMonth();
            emp.PartTimeWagesPerMonth();
        }
    }
}
