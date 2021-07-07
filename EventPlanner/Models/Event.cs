using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace EventPlanner.Models
{
    public class Event
    {
        [Key]
        public int EventId {get;set;}

        [Required]
        public string Title {get;set;}

        [Required]
        public DateTime Date {get;set;}

        [Required]
        public string Description {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public int UserId {get;set;}
        public User Creator {get;set;}
        public List<Attendee> Attendees {get;set;}
    }
}