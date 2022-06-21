using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSimulator.Models
{
    public class Housing
    {
        public int HousingId { get; set; }
        public int NumberOfYears { get; set; } // May need to change to NumberOfSemesters
        public double Cost { get; set; }
        public CostBreakdown CostBreakdown { get; set; }
        public HousingType HousingType { get; set; }
        public ResidencyType ResidencyType { get; set; }
    }

    public enum CostBreakdown
    {
        Semester,
        Month,
        Year
    }
    public enum HousingType
    {
        OnCampus,
        OffCampus,
        AtHome
    }
    public enum ResidencyType
    {
        InState,
        OutOfState
    }
}
