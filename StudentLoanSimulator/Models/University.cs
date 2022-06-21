using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSimulator.Models
{
    public class University
    {
        public int UniversityId { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
        public Residency Residency { get; set; }
        public decimal YearlyTuition { get; set; } // TODO Don't know that decimals are the right thing to use here. Consider changing to cost per credit hour and add property for credit hours needed
        public decimal ScholarshipAmount { get; set; }
        public decimal GrantAmount { get; set; }
        public decimal SchoolYearLength { get; set; } // Months ex 8.5, 8.25
        public decimal SemesterLength { get; set; } // See above SchoolYearLength
    }

    public enum Residency
    {
        InState,
        OutOfState
    }
}
