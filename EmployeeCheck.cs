using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeCheck
    {
        public const int presentFullTime = 1;
        public const int presentHalfTime = 2;
        public const int hourlyWage = 20;
        public static void CheckEmployee()
        {
            
            int empHours = 0;
            int dailyWage = 0;

            Random random = new Random();
            int empCheck = random.Next(3);

            switch(empCheck)
            {
                case presentFullTime:
                    Console.WriteLine("Present Full Time");
                    empHours = 8;
                    break;
                case presentHalfTime:
                    Console.WriteLine("Present Half Time");
                    empHours = 4;
                    break;
                default:
                    Console.WriteLine("Absent");
                    empHours = 0;
                    break;
            }
            dailyWage = empHours * hourlyWage;
            Console.WriteLine("Employee's Wage Today: "+ dailyWage);
        }
    }
}
