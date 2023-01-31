using Day8MVC.Models;
using Day8MVC.ViewModel;

namespace Day8MVC.Services
{
    public interface IEmployeeService
    {
        List<EmployeeVM> GetAll();
        EmployeeVM GetById(int id);
        //int Add(Employee employee);
        //int Edit(Employee employee);
        //int Delete(Employee employee);
    }
}