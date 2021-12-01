
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWageComputationProblem
{
    class program
    {
      
       
        static void Main(string[] args)
        {
            EmpWageBuilderObject Dmart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject Reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);

            Dmart.ComputeEmpWage();
            Console.WriteLine(Dmart.ToString());

            Reliance.ComputeEmpWage();
            Console.WriteLine(Reliance.ToString());
        }
        
    }
}