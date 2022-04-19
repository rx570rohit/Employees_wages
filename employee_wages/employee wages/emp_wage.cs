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
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
       
        public static void empcalculation()
        {       int emphrs = 0, empwage = 0, totalEmpWages = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++) {
                //variables
               
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

                empwage = emphrs * EMP_RATE_PER_HOUR;
                totalEmpWages += empwage;
                
            }
            Console.WriteLine("Emp Wage :" + empwage);
            Console.WriteLine("Total Emp Wage :" + totalEmpWages);
        }
    }
}
