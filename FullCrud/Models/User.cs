using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FullCrud.Models
{
    public class User
    {
        public int UserId {get;set;}
        
        [Required(ErrorMessage ="Bruh, This is required yo!")]
        [MinLength(3, ErrorMessage ="Hey! That's not 3 Characters!")]
        [Display(Name = "Unicorns")]

        public string FirstName {get;set;}


        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Message> CreatedMessages {get;set;}
    }
}