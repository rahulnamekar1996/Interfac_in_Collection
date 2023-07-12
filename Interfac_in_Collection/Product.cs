using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfac_in_Collection
{
    public class Employee:IComparable<Employee>
    {
        public int id;
        public double sallary;


        public Employee(int id, double sallar)
        {
            this.id = id;
            this.sallary = sallar;
        }

        public int CompareTo(Employee other)
        {
            if(this.sallary < other.sallary)
            {
                return -1;
            }
            else if(this.sallary > other.sallary)
            {
                return 1;
            }
            else
            {
                return 0; 
            }
            
           
        
        }

        public override string ToString()
        {
            return $"{id} {sallary}";
        }
      
    }


}
