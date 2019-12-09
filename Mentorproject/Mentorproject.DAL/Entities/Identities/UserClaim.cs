using System;
using Microsoft.AspNetCore.Identity;

namespace Mentorproject.DAL.Entities.Identities
{
    public class UserClaim: IdentityUserClaim<Guid>
    {
        public virtual User User { get; set; }
    }
}