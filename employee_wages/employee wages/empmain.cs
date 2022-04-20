using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_wages
{
    internal class empmain 
    {
        public static void Main(String[] arg)
        {
            emp_wage dmart = new emp_wage("Dmart",20,2,10);
            emp_wage tataclick = new emp_wage("tataClick", 10, 4, 20);
            dmart.empcalculation();
            tataclick.empcalculation();
        }
    }
}