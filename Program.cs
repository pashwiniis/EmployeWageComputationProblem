
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWageComputationProblem
{
    class EmployeeCheck
    {
        static void Main(string[] args)
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
                ///Console.WriteLine("Employee is present");
                empHrs = 4;
                
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
               
            }
            else
            {
                ///Console.WriteLine("Employee is absent");
                empHrs = 0;
                
            }
            empWage = empHrs *  EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage Per day is :" + empWage);
            Console.ReadLine();
        }
    }
}