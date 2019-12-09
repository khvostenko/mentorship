using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using Mentorproject.DAL.Entities.Identities;

namespace Mentorproject.DAL.Entities
{
    public class User: IdentityUser<Guid>
    {
        public Guid PositionId { get; set; }
        public virtual Position Position { get; set; }
        public virtual ICollection<UserProject> UserProjects { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<UserClaim> Claims { get; set; }
        public virtual ICollection<UserLogin> Logins { get; set; }
        public virtual ICollection<UserToken> Tokens { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
