using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class CommissionEmployee : Employee
    {
        private decimal grossSales;
        private decimal commissionRate;
        public decimal GrossSales 
        {
            get
            {
                return grossSales;
            }
            set
            {
                grossSales = value >= 0 ? value : 0;
            }
        }
        public decimal CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                commissionRate = (value > 0 && value < 1) ? value : 0;
            }
        }
        public CommissionEmployee(string first, string last, string ssn, decimal grossSal,decimal comRate) : base(first, last, ssn)
        {
            GrossSales = grossSal;
            CommissionRate = comRate;
        }

        public override decimal Earnings()
        {
            return CommissionRate * GrossSales;
        }
        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}", "commission employee", base.ToString(),"gross sales", GrossSales, "commission rate", CommissionRate);
        }
    }
}
