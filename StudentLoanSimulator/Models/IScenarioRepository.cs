using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSimulator.Models
{
    public interface IScenarioRepository
    {
        IEnumerable<Scenario> AllScenarios { get; }
        Scenario GetScenarioById(int scenarioId);
    }
}
