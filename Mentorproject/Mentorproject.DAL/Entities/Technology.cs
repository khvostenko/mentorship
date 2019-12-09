using System;

namespace Mentorproject.DAL.Entities
{
    public class Technology
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}