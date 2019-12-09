using System;
using Microsoft.AspNetCore.Identity;

namespace Mentorproject.DAL.Entities.Identities
{
    public class UserLogin : IdentityUserLogin<Guid>
    {
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}