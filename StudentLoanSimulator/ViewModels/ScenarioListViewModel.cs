using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentLoanSimulator.Models;

namespace StudentLoanSimulator.ViewModels
{
    public class ScenarioListViewModel
    {
        public IEnumerable<Scenario> Scenarios { get; set; }
        public string Title { get; set; }
    }
}
