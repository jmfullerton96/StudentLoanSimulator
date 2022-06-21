using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentLoanSimulator.Models;
using StudentLoanSimulator.ViewModels;

namespace StudentLoanSimulator.Controllers
{
    public class ScenarioController : Controller
    {
        private readonly IScenarioRepository _scenarioRepository;

        public ScenarioController(IScenarioRepository scenarioRepository) // Dependency injection from asp.net core will make sure these types are provided anytime a new instance is created. I.e. Startup.ConfigureServices()
        {
            _scenarioRepository = scenarioRepository;
        }

        public ViewResult List() // Corresponds to Views\Scenario\List.cshtml
        {
            ScenarioListViewModel scenarioListViewModel = new ScenarioListViewModel();
            scenarioListViewModel.Scenarios = _scenarioRepository.AllScenarios;
            scenarioListViewModel.Title = "All Scenarios";
            // To pass along extra data to the view implement ViewBag and then call @ViewBag in the cshtml         
            return View(scenarioListViewModel);
        }
    }
}
