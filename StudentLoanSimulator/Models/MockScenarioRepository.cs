using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSimulator.Models
{
    public class MockScenarioRepository : IScenarioRepository
    {
        public IEnumerable<Scenario> AllScenarios =>
            new List<Scenario>
            {
                new Scenario{ScenarioId=1},
                new Scenario{ScenarioId=2},
                new Scenario{ScenarioId=3}
            };

        public Scenario GetScenarioById(int scenarioId)
        {
            return AllScenarios.FirstOrDefault(s => s.ScenarioId == scenarioId);
        }
    }
}
