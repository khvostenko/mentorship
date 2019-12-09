using System;

namespace Mentorproject.DAL.Entities
{
    public class UserProject
    {
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public Guid ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}