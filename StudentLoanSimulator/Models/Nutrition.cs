using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSimulator.Models
{
    public class Nutrition
    {
        public int NutritionId { get; set; }
        public int MealsPerDay { get; set; }
        public double Budget { get; set; }
        public double DaysFedWithinBudget { get; set; }
        public double DaysNotFedWithinBudget { get; set; }
        public double TimeSpan { get; set; } // used in combination with Duration to make calculations
        public Source Source { get; set; }
        public Duration Duration { get; set; }
    }

    public enum Source
    {
        DinningHall,
        EatingOut,
        HomeCooked
    }
    public enum Duration
    {
        SchoolYear, // Have the user determine how long the school year actually is
        Year,
        Semester, // Have the user determine how long the semester actually is
        Months,
        Days
    }
}
