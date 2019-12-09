using Microsoft.AspNetCore.Identity;
using System;

namespace Mentorproject.DAL.Entities.Identities
{
    public class UserToken:IdentityUserToken<Guid>
    {
        public virtual User User { get; set; }
    }
}
