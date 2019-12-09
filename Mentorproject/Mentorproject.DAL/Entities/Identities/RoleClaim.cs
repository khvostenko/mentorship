using System;
using Microsoft.AspNetCore.Identity;

namespace Mentorproject.DAL.Entities.Identities
{
    public class RoleClaim: IdentityRoleClaim<Guid>
    {
        public virtual Role Role { get; set; }
    }
}