using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWageComputationProblem
{
    public  class EmpWageBuilder: IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private LinkedList<CompanyEmpWage> companyEmpWagesList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;
        public EmpWageBuilder()
        {
            this.companyEmpWagesList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }
        public  void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWagesList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);

        }
        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWagesList)
            {
                companyEmpWage.SetTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }

        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;

            int totalWorkingDays = 0;


            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int randomInput = random.Next(0, 3);
                switch (randomInput)
                {

                    case IS_PART_TIME:
                        empHrs = 4;

                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;

                        break;

                    default:
                        empHrs = 0;

                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#:" + totalWorkingDays + " Emphrs : " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
        
      public int getTotalWage(string company)
      {
            return companyToEmpWageMap[company].totalEmpWage;
      }

        
    }
}
