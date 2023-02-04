using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Day8MVC.ViewModel
{
    public class EmployeeVM
    {
        public int SSN { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public double? Salary { get; set; }
        public DateTime Bdate { get; set; }
        public string? Sex { get; set; }
        public int ? ESSN{ get; set; }
    }
}
