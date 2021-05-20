using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicSalary
{
    class Salary
    {
        public int basicSalary;
        public int houseRent;
        public int medicalAllowance;
        public int conveyanceAllowance;
        public Currency currency;

        double bs_percent;
        double hr_percent;
        double ma_percent;
        double ca_percent;


        ///-----------Gross Salary Calculate---------/
        public int CalculateByBasicSalary(int basicSalary)
        {
            this.bs_percent = 0.50; // 50% basic
            this.hr_percent = 0.30; // 30% house
            this.ma_percent = 0.10; // 10% medical
            this.ca_percent = 0.10; // 10% conveyance

            //-------------------------------
            // Basic                 100%
            this.currency = Currency.BDT;

            this.basicSalary = basicSalary;
            this.houseRent = Convert.ToInt32(basicSalary * 0.30);
            this.medicalAllowance = Convert.ToInt32(basicSalary * 0.10);
            this.conveyanceAllowance = Convert.ToInt32(basicSalary * 0.10);
            var re = this.basicSalary + this.houseRent + this.medicalAllowance + this.conveyanceAllowance;
            return re;
        }

    }

    public enum Currency
    {
        BDT, RS, USD, ERO, CNY, YEN
    }
}
