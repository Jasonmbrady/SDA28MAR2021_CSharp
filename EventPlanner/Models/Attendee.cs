using System.ComponentModel.DataAnnotations;
using System;

namespace EventPlanner.Models
{
    public class Attendee
    {
        [Key]
        public int AttendeeId {get;set;}
        public int UserId {get;set;}
        public int EventId {get;set;}
        public User User {get;set;}
        public Event Event {get;set;}
    }
}