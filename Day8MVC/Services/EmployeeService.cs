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
                LastName = employee.LastName,
                Salary = employee.Salary,
                Address=employee.Address
            };
            return employeeVM;
        }
        //public int Add(Employee employee)
        //{
        //    emp = employeeRepo.Add(employee);
        //    EmployeeVM employeeVM = new()
        //    {
        //        SSN = employee.SSN,
        //        FirstName = employee.FirstName,
        //        MiddleName = employee.MiddleName,
        //        LastName = employee.LastName
        //    };
        //    return employeeRepo.Add(employeeVM);
        //}

        public int Edit(EmployeeVM employee)
        {
            Employee employee1 = new Employee();
            return employeeRepo.Edit(employee1);
        }
        public int Delete(int id)
        {  
            return employeeRepo.Delete(id); ;
        }

        public int Add(EmployeeVM employeevm)
        {
            Employee employee = new Employee();
            employee.FirstName= employeevm.FirstName;
            employee.Salary=employeevm.Salary;
            employee.Address=employeevm.Address;
            employee.LastName=employeevm.LastName;
            employee.MiddleName= employeevm.MiddleName;
            return employeeRepo.Add(employee);
        }
    }
}
