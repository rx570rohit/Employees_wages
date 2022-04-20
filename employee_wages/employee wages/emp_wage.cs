using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_wages
{
    internal class emp_wage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        private String company;
        private int empRatePerHour;
        private int noOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public  emp_wage(String company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.noOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void empcalculation() { 
            //variables
            int emphrs = 0, totalEmpHrs = 0, totalWorkingDays=0;

            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.noOfWorkingDays) {
               
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
            this.totalEmpWage = totalEmpHrs + this.empRatePerHour;

            Console.WriteLine("Total Emp Wage for " + this.company + ": "+this.totalEmpWage);
        }
    }
}
