using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;
using BusinessLayer.Validation_Rules;
using FluentValidation.Results;

namespace PresentationLayer.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            var values = _teamService.GetListAll();
            return View(values);
        }

        [HttpGet] 
        public IActionResult AddTeam()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTeam(Team team)
        {
            ModelState.Clear();
            TeamValidator validationRules = new TeamValidator();
            ValidationResult result = validationRules.Validate(team);
            if (result.IsValid)
            {
                _teamService.Add(team);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }            
        }

        public IActionResult DeleteTeam(int id)
        {
            var value = _teamService.GetById(id);
            _teamService.Delete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditTeam(int id)
        {
            var value = _teamService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditTeam(Team team)
        {
            TeamValidator validationRules = new TeamValidator();
            ValidationResult result = validationRules.Validate(team);
            if (result.IsValid)
            {
                _teamService.Update(team);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var failure in result.Errors)
                {
                    ModelState.AddModelError(failure.PropertyName, failure.ErrorMessage);
                }
                return View(team);
            }
        }

    }
}
