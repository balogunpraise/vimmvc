﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsSubscribed { get; set; }
        public bool IsStudent { get; set; }
        //public virtual ICollection<Course> Courses { get; set; }
    }
}
