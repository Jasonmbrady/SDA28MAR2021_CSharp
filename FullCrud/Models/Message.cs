using System;
using System.ComponentModel.DataAnnotations;

namespace FullCrud.Models
{
    public class Message
    {
        [Key]
        public int MessageId {get;set;}
        public string Content {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public int UserId {get;set;}

        // Navigation Property
        public User Creator {get;set;}
    }
}