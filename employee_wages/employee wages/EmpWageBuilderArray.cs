using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_wages
{
    internal class EmpWageBuilder: IComputeEmpWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<String, CompanyEmpWage> companyToEmpWageMap;
        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<String, CompanyEmpWage>();
        }
        public void addCompanyEmpWage(String company, int empRatePerHour, int noOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company,empRatePerHour,noOfWorkingDays,maxHoursPerMonth);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company,companyEmpWage);
        }

        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.tostring());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {

            int emphrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.noOfWorkingDays)
            {

                totalWorkingDays++;

                Random obj = new Random();
                int empcheck = obj.Next(1, 2);

                switch (empcheck)
                {
                    case IS_FULL_TIME:
                        emphrs = 8;
                        break;
                    case IS_PART_TIME:
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }

                totalEmpHrs = totalEmpHrs + emphrs;
                Console.WriteLine("Day#: " + totalWorkingDays + " EMP Hrs :" + emphrs);

            }
            return totalEmpHrs * companyEmpWage.empRatePerHour ;
        }
        public int getTotalWage(String company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }
    }
}
