using Day8MVC.Reposiotries;
namespace Day8MVC.Services
{
    public class DI
    {
        private IEmployeeRepo employeeRepo;
        public void SetDependency(IEmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }
        public IEmployeeRepo employeeRepo1
        {
            set
            {
                employeeRepo = value;
            }
        }
    }
    public class factory
    {
        public static IEmployeeRepo getObject()
        {
            return new EmployeeRepo(new Models.CompanyDbContext());
        }
    }

    public class myMain
    {
        public void myMainFunc()
        {
            DI dI = new DI();
            dI.employeeRepo1 = factory.getObject();
        }
    }
}
