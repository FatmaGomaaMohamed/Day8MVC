using Day8MVC.Models;
using Day8MVC.Services;
using Day8MVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day8MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        public IActionResult Index()
        {
            return View(employeeService.GetAll());
        }
        public IActionResult GetById(int id)
        {
            return View(employeeService.GetById(id));
        }
        public IActionResult delete(int id)
        {
            employeeService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        
        [HttpGet]
        public IActionResult Add()
        {
            return View(employeeService.GetAll());
        }
        [HttpPost]
        public IActionResult AddDB(EmployeeVM emp)
        {
            employeeService.Add(emp);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(Employee emp)
        {
            return View(employeeService.GetAll());
        }
        public IActionResult EditDB(EmployeeVM emp)
        {
            employeeService.Edit(emp);
            return RedirectToAction(nameof(Index));
        }
    }
}
