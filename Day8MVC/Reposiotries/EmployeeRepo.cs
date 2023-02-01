using Day8MVC.Models;
namespace Day8MVC.Reposiotries
{
    public class EmployeeRepo : IEmployeeRepo
    {
        CompanyDbContext context;
        public EmployeeRepo(CompanyDbContext context)
        {
            this.context = context;
        }
        public List<Employee> GetAll()
        {
            return context.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return context.Employees.SingleOrDefault(s => s.SSN == id);
        }

        public int Add(Employee employee)
        {
            try
            {
                context.Employees.Add(employee);
                return context.SaveChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int Edit(Employee employee)
        {
            try
            {
                Employee oldEmployee = context.Employees.SingleOrDefault(s => s.SSN == employee.SSN);
                oldEmployee.FirstName = employee.FirstName;
                oldEmployee.Address = employee.Address;
                return context.SaveChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int Delete(int id)
        {
            Employee employee = GetById(id);
            context.Employees.Remove(employee);
            return context.SaveChanges();
        }
    }

}

