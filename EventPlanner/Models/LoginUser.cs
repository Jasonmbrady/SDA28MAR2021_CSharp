using System.ComponentModel.DataAnnotations;


namespace EventPlanner.Models
{
    public class LoginUser
    {
        [EmailAddress]
        [Display(Name ="Email")]
        [Required]
        public string logEmail {get;set;}
        [Required]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        public string logPassword {get;set;}
    }
}