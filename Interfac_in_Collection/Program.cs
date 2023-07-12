using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfac_in_Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Team india = new Team();

            foreach(Player p in india)
            {
                Console.WriteLine(p);
            }


            Employee rohan = new Employee(1, 25000);
            Employee Abhishek = new Employee(2, 30000);

            int result=rohan.CompareTo(Abhishek);

            if (result < 0)
            {
                Console.WriteLine("rohan sallaey is less");
            }
            else if (result > 0)
            {
                Console.WriteLine(" rohan sallary is greater");

            }
            else
            {


                Console.WriteLine("rohan and abhishkh ha same sallary");
             }      
        
      
            // using comparer interface

            Employee_1 kartik =new Employee_1 { Id = 1 ,sallary=20000};
            Employee_1 shreysh = new Employee_1 { Id = 2, sallary = 25000 };

            SallayComparison obj= new SallayComparison();
            int result1 = obj.Compare(kartik, shreysh);
            if (result1 < 0)
            {
                Console.WriteLine("kartik has more sallary ");

            }
            else if (result1 > 0)
            {
                Console.WriteLine(" kartik has less sallay");

            }
            else
            {
                Console.WriteLine(("both have same sallary"));
            }
                

                 
                    
                    
                    
        }
    }
}
