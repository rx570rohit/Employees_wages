using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_wages
{
    internal class EmpMain 
    {
        public static void Main(String[] arg)
        {
          
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();

            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("tata",10,4,20);
            empWageBuilder.computeEmpWage();
        }
    }
}