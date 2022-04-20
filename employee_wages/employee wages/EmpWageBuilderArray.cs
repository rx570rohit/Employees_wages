using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_wages
{
    internal class EmpWageBuilderArray
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private int noOfCompany = 0;
        private CompanyEmpWage[] companyEmpWagesArray;
        public EmpWageBuilderArray()
        {
            this.companyEmpWagesArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(String company, int empRatePerHour, int noOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWagesArray[this.noOfCompany] = new CompanyEmpWage(company, empRatePerHour, noOfWorkingDays, maxHoursPerMonth);
            noOfCompany++;      
        }
        
        public void computeEmpWage()
        {
            for (int i = 0; i < noOfCompany; i++)
            {
                companyEmpWagesArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWagesArray[i]));
                Console.WriteLine(companyEmpWagesArray[i].tostring());
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
    }
}
