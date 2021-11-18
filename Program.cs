
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWageComputationProblem
{
    class EmployeeCheck
    {
       public const int IS_PART_TIME = 1;
       public const int IS_FULL_TIME = 2;
       public const int EMP_RATE_PER_HOUR = 20;
        static void Main(string[] args)
        {
            
            int empHrs = 0;
            int empWage = 0;
            string typeOfEmployee = "";


            Random random = new Random();
            int randomInput = random.Next(0, 3);
            switch (randomInput)
            {
                ///Console.WriteLine("Employee is present");
                case IS_PART_TIME:
                     empHrs = 4;
                    typeOfEmployee = "Parttime";
                     break;
            
                case IS_FULL_TIME:
                     empHrs = 8;
                    typeOfEmployee = "Fulltime";
                     break;
            
                default:
                     empHrs = 0;
                    typeOfEmployee = "Absent";
                     break;
             }
            empWage = empHrs *  EMP_RATE_PER_HOUR;
            Console.WriteLine(typeOfEmployee + "Employee Wage Per day is :" + empWage);
            Console.ReadLine();
        }
    }
}