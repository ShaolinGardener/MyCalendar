using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyCalendar.Models
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Class Class { get; set; }
        public List<User> Instructor { get; set; }

    }
}