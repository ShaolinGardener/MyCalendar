using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyCalendar.Models
{
    public class Class
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<User> Instructors { get; set; }
        public User PrimaryInstructor { get; set; }

    }
}