using System.ComponentModel.DataAnnotations;

namespace BigBangTest.Auth
{
    public class LoginModule
    {
        [Required(ErrorMessage = "Uername required")] public string? User_name { get; set; }
        [Required(ErrorMessage = "Password required")] public string? Password { get; set; }
    }
}