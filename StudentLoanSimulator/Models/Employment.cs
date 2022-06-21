using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSimulator.Models
{
    public class Employment
    {
        //public int EmploymentId { get; set; }
        public bool Emplyeed { get; set; }
        public double Wage { get; set; }
        public WageBreakdown WageBreakdown { get; set; }
        public Location Location { get; set; }
    }

    public enum WageBreakdown
    {
        Hourly,
        Salary
    }
}
