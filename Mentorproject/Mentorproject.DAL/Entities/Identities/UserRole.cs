using System;
using Microsoft.AspNetCore.Identity;

namespace Mentorproject.DAL.Entities.Identities
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}