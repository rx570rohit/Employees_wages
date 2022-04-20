using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_wages
{
    internal interface IComputeEmpWage
    {
        public void addCompanyEmpWage(String company, int empRatePerHour, int noOfWorkingDays, int maxHoursPerMonth);
        public void computeEmpWage();
        public int getTotalWage(String company);
    }
}
