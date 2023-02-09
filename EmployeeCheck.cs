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
            int present = 1;
            int hourlyWage = 20;
            int empHours = 0;
            int dailyWage = 0;

            Random random = new Random();
            int empCheck = random.Next(2);

            if(empCheck == present)
            {
                Console.WriteLine("Employee is Present");
                empHours = 8;

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
