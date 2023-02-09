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
        //public const int hourlyWage = 20;
        public static void CheckEmployee()
        {
            
            int empHours = 0;
            int dailyWage = 0;
            int monthlyWage = 0;
            //int workingDays = 30;
            int hourlyWage = 20;
            int maxHours = 100;
            int maxDays = 20;
            int hrs = 0;
            int days = 0;


            while (hrs <= maxHours && days < maxDays)
            {
                Random random = new Random();
                int empCheck = random.Next(3);
                switch (empCheck)
                {
                    case presentFullTime:
                        //Console.WriteLine("Present Full Time");
                        empHours = 8;
                        break;
                    case presentHalfTime:
                        //Console.WriteLine("Present Half Time");
                        empHours = 4;
                        break;
                    default:
                        //Console.WriteLine("Absent");
                        empHours = 0;
                        break;
                }
                hrs = hrs + empHours;
                days++;
                dailyWage = empHours * hourlyWage;
                Console.WriteLine("Today's Wage: " + dailyWage);
                monthlyWage = monthlyWage + dailyWage;
            }

            Console.WriteLine("Hours Worked: "+ hrs);
            Console.WriteLine("Days Worked: "+ days);
            Console.WriteLine("Employee's Monthly Wage : "+ monthlyWage);
        }
    }
}
