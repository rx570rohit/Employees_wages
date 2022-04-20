using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_wages
{
    internal class CompanyEmpWage
    {

        public String company;
        public int empRatePerHour;
        public int noOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public  CompanyEmpWage(String company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.noOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage) { this.totalEmpWage = totalEmpWage; }

        public String tostring() { return "Total Emp Wage for company : " + this.company + " is " + this.totalEmpWage; }
        
    }
}
