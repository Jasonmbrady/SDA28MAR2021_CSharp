using System.ComponentModel.DataAnnotations;

namespace LoginReg.Models
{
    public class LoginUser
    {
        [EmailAddress]
        [Required]
        public string Email {get;set;}

        [Required]
        public string Password {get;set;}
    }
}