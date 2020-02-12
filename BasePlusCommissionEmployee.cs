using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        private decimal baseSalary;
        public decimal BaseSalary 
        {
            get
            {
                return baseSalary;
            }
            set
            {
                baseSalary = value >= 0 ? value : 0;
            }
        }
        public BasePlusCommissionEmployee(string first, string last, string ssn, decimal grossSal, decimal comRate, decimal bSalary) : base(first, last, ssn, grossSal, comRate)
        {
            BaseSalary = bSalary;
        }
        public override string ToString()
        {
            return string.Format("base-salaried {0}; base salary: {1:C}",   base.ToString(), BaseSalary);
        }
        public override decimal Earnings()
        {
            return BaseSalary + base.Earnings();
        }
    }
}
