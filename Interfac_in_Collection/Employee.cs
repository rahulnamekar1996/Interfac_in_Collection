using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfac_in_Collection
{
    public class Employee_1
    {
        public int Id { get; set; }
        public double sallary { get; set; }

    
    
    }



    public class SallayComparison : IComparer<Employee_1>
    {
        public int Compare(Employee_1 x, Employee_1 y)
        {
            if (x.sallary < y.sallary)
            {
                return -1;
            }
            else if (x.sallary > y.sallary)
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        
        } 


    }
}

