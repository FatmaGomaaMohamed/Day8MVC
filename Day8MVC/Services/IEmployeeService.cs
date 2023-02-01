using Day8MVC.Models;
using Day8MVC.ViewModel;

namespace Day8MVC.Services
{
    public interface IEmployeeService
    {
        int Add(Employee employeevm);
        int Delete(int id);
        int Edit(EmployeeVM employeevm);
        List<EmployeeVM> GetAll();
        EmployeeVM GetById(int id);
    }
}