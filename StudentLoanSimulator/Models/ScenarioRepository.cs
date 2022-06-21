using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSimulator.Models
{
    public class ScenarioRepository : IScenarioRepository
    {
        private readonly AppDbContext _appDbContext;
        public ScenarioRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Scenario> AllScenarios
        {
            get
            {
                return _appDbContext.Scenarios;
                //return _appDbContext.Scenarios.Include(s => s.Employment);
                //return _appDbContext.Scenarios.Include(s => s.Employment).Where(s => s.Uni.IsNotNull); // just an exmaple
            }
        }

        public Scenario GetScenarioById(int scenarioId)
        {
            return _appDbContext.Scenarios.FirstOrDefault(s => s.ScenarioId == scenarioId);
        }
    }
}
