using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlanner.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required]
        public string FirstName {get;set;}
        [Required]
        public string LastName{get;set;}
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        [Required]
        [MinLength(8, ErrorMessage ="Password must be at least 8 characters")]
        [DataType(DataType.Password)]
        public string Password {get;set;}
        [NotMapped]
        [Required]
        [Compare("Password", ErrorMessage ="Passwords must match")]
        [DataType(DataType.Password)]
        public string ConfirmPW {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;


    }
}