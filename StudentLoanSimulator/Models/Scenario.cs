using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSimulator.Models
{
    public class Scenario
    {
        public int ScenarioId { get; set; }
        public string Name { get; set; }
        public List<University> Universities { get; set; } // May attend one uni for 2 years and another for 2. Gives way to transfer scenarios, exc
        public List<Housing> Housing { get; set; } // Likely on campus one year and off campus others. May be considered out of state two years and in state another two, exc
        public EmploymentScenarios EmploymentScenarios { get; set; }
        public int EmploymentId { get; set; }
        public Nutrition Nutrition { get; set; }
        public Miscelaneous Miscelaneous { get; set; } // Includes things like gas, uber, insurance, phone bill (any extra bill), alcohol, spring break trips, concerts, football games, other sports games
    }
}
