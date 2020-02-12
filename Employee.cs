﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public abstract class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string SocialSecurityNumber { get; private set; }
        public Employee(string first, string last, string ssn)
        {
            FirstName = first;
            LastName = last;
            SocialSecurityNumber = ssn;
        }
        public abstract decimal Earnings();
        public override string ToString()
        {
            return string.Format("{0} {1}\nsocial secuirity number: {2}", FirstName, LastName, SocialSecurityNumber);
        }
    }
}
