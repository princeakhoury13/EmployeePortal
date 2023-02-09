using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeCheck
    {
        public static void CheckEmployee()
        {
            int presentFullTime = 1;
            int presentHalfTime = 2;
            int hourlyWage = 20;
            int empHours = 0;
            int dailyWage = 0;

            Random random = new Random();
            int empCheck = random.Next(3);

            if(empCheck == presentFullTime)
            {
                Console.WriteLine("Employee is Present Full Time");
                empHours = 8;

            }
            else if (empCheck == presentHalfTime)
            {
                Console.WriteLine("Employee is Present Half Time");
                empHours = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHours = 0;
            }
            dailyWage = empHours * hourlyWage;
            Console.WriteLine("Employee's Wage Today: "+ dailyWage);
        }
    }
}
