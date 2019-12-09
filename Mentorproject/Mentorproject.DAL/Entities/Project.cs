using System;
using System.Collections.Generic;

namespace Mentorproject.DAL.Entities
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<UserProject> UserProjects { get; set; }
        public bool IsDeleted { get; set; }
    }
}
