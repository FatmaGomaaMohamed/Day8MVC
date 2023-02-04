using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Day8MVC.ViewModel
{
    public class UserToRoleVM
    {
        [Key]
        [Display(Name = "User")]
        public string UserId { get; set; }
        [Display(Name = "Role")]
        public string RoleName { get; set; }
        public SelectList Users { get; set; }
        public SelectList Roles { get; set; }
    }
}
