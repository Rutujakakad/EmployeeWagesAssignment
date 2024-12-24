using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmployeeWages
    {
        public int FullTime = 1;
        public int PartTime = 2;
        public int wage_per_hr = 20;
        public int full_day_hr = 8;
        public int part_time_hr = 8;
        public int working_days = 20;


        public void Attendance()
        {
            Random rndm = new Random();
            int attendance = rndm.Next(0, 3);


            switch (attendance)
            {
                case 1: 
                    Console.WriteLine($"Employee is Present: {FullTime}.");
                    break;
                case 2: 
                    Console.WriteLine($"Employee is Present {PartTime}.");
                    break;
                default:
                    Console.WriteLine("Employee is Absent.");
                    break;
            }
        }
        public void DailyEmployeeWage()
        {
            int DailyEmployeeWage = wage_per_hr * full_day_hr;
            Console.WriteLine($"Daily Employee Wage is: {DailyEmployeeWage}");
            
        }
        public void PartTimeEmployeeWage()
        {
            int PartTimeEmployeeWage = part_time_hr * wage_per_hr;
            Console.WriteLine($"Part Time Employee Wage is: {PartTimeEmployeeWage}");
        }

        public void WagesPerMonth()
        {
            int WagesPerMonth = working_days * wage_per_hr * full_day_hr; 
            Console.WriteLine($"Wages for a fulltime employee for a  month is: {WagesPerMonth}");
        }

        public void PartTimeWagesPerMonth()
        {
            int ParttimeForMonth = working_days * part_time_hr * wage_per_hr;
            Console.WriteLine($"Wages for a parttime employee for a month is: {ParttimeForMonth}");
        }
    }
}
