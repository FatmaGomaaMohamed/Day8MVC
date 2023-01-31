using Day8MVC.Controllers;
using Day8MVC.Reposiotries;
using Day8MVC.ViewModel;
using Day8MVC.Models;
using System.Runtime.CompilerServices;
namespace Day8MVC.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepo employeeRepo;
        public EmployeeService(IEmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }

        public List<EmployeeVM> GetAll()
        {
            List<Employee> employees = employeeRepo.GetAll();

            List<EmployeeVM> employeeVMs = new List<EmployeeVM>();
            foreach (var emp in employees)
            {
                employeeVMs.Add(new EmployeeVM()
                {
                    SSN = emp.SSN,
                    FirstName = emp.FirstName,
                    MiddleName = emp.MiddleName,
                    LastName = emp.LastName,
                });
            }
            return employeeVMs;
        }
       
        public EmployeeVM GetById(int id)
        {
            Employee employee = employeeRepo.GetById(id);
            EmployeeVM employeeVM = new()
            {
                SSN = employee.SSN,
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName
            };
            return employeeVM;
        }
        //public int Add(Employee employee)
        //{
        //    return employeeRepo.Add(employee);
        //}

        //public int Delete(Employee employee)
        //{
        //    throw new NotImplementedException();
        //}

        //public int Edit(Employee employee)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
