using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            doSalary2();
            Console.ReadKey();
        }

        static void doSalary2()
        {
            Console.WriteLine("Input Basic Salary");
            var bs = Console.ReadLine();
            Salary s = new Salary();
            var bsReturn = s.CalculateByBasicSalary(Convert.ToInt32(bs));
            Console.WriteLine(">> Basic Salary:         {0}/= {1}", s.basicSalary, s.currency);
            Console.WriteLine(">> House Rent:           {0}/= {1}", s.houseRent, s.currency);
            Console.WriteLine(">> Medical Allowance:    {0}/= {1}", s.medicalAllowance, s.currency);
            Console.WriteLine(">> Conveyance Allowance: {0}/= {1}", s.conveyanceAllowance, s.currency);
            Console.WriteLine("......................................");
            Console.WriteLine("   Gross Salary:         {0}/= {1}", bsReturn, s.currency);
        }
    }
}
