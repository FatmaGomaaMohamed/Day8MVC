using System.ComponentModel.DataAnnotations;

namespace Day8MVC.ViewModel
{
    public class LoginVM
    {       
            [Key]
            public string Email { get; set; }

            public string Password { get; set; }
            public bool RememberMe { get; set; }
    }
}
