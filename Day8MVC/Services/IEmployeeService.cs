using Day8MVC.Models;
using Day8MVC.ViewModel;

namespace Day8MVC.Services
{
    public interface IEmployeeService
    {
        int Add(Employee employee);
        int Delete(int id);
        int Edit(Employee employee);
        List<EmployeeVM> GetAll();
        EmployeeVM GetById(int id);
    }
}