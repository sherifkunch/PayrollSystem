using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class SalariedEmployee : Employee
    {
        private decimal weeklySalary { get; set; }
        public decimal WeeklySalary 
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                weeklySalary = ((value >= 0 ) ? value : 0);
            }
        }
        public SalariedEmployee(string first, string last,string ssn, decimal weekSal) : base(first,last,ssn)
        {
            WeeklySalary = weekSal;
        }
        public override decimal Earnings()
        {
            return WeeklySalary;
        }
        public override string ToString()
        {
            return string.Format("salaried employee: {0}\n{1}: {2:c}",base.ToString(),"weekly salary",WeeklySalary);
        }
    }
}
