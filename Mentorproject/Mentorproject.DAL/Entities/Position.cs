using System;

namespace Mentorproject.DAL.Entities
{
    public class Position
    {
        public Guid Id { get; set; }
        public string Level { get; set; }
        public Guid TechnologyId { get; set; }
        public virtual Technology Technology { get; set; }
        public bool IsDeleted { get; set; }
    }
}