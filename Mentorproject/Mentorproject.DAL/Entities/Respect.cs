using System;

namespace Mentorproject.DAL.Entities
{
    public class Respect
    {
        public Guid Id { get; set; }
        public Guid FromUserId { get; set; }
        public virtual User FromUser { get; set; }
        public Guid ToUserId { get; set; }
        public virtual User ToUser { get; set; }
        public DateTime Date { get; set; }
        public Status Status { get; set; }
        public bool IsDeleted { get; set; }
    }
}