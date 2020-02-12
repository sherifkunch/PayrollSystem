using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class HourlyEmployee : Employee
    {
        private decimal hours;
        private decimal wage;
        public decimal Wage
        {
            get
            {
                return wage;
            }
            set
            {
                wage = value >= 0 ? value : 0;
            }
        }
        public decimal Hours
        {
            get
            {
                return hours;
            }
            set
            {
                hours = (value >= 0) && (value <= 168) ? value : 0;
            }
        }
        public HourlyEmployee(string first, string last, string ssn, decimal hoursWorked, decimal hourlyWage) : base(first, last, ssn)
        {
            Hours = hoursWorked;
            Wage = hourlyWage;
        }

        public override decimal Earnings()
        {
            if (hours <= 40)
            {
                return wage * hours;
            }
            else
            {
                return (40 * wage) + (hours - 40) * wage * 1.5M;
            }

        }
        public override string ToString()
        {
            return string.Format("hourly employee: {0}\n{1}: {2:C}\n{3}: {4:F2}", base.ToString(), "hourly wage", Wage, "hours worked", Hours);
        }
    }
}
