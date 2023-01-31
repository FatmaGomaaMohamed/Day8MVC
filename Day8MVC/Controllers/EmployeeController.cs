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
            List<EmployeeVM> employeeVMs = employeeService.GetAll();
            return View(employeeVMs);
        }
        
    }
}
