using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Mentorproject.DAL.Entities.Identities
{
    public class Role : IdentityRole<Guid>
    {
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<RoleClaim> RoleClaims { get; set; }
    }
}