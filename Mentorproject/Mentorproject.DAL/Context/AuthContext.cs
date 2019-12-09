using Mentorproject.DAL.Configurations;
using Mentorproject.DAL.Entities;
using Mentorproject.DAL.Entities.Identities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Mentorproject.DAL.Context
{
    public class AuthContext:IdentityDbContext<User, Role, Guid,
        UserClaim, UserRole, UserLogin,
        RoleClaim, UserToken>
    {
        public AuthContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserClaim> UserClaims { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserToken> UserTokens { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleClaim> RoleClaims { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserLoginConfiguration());
            builder.ApplyConfiguration(new UserClaimConfiguration());
            builder.ApplyConfiguration(new UserRolesConfiguration());
            builder.ApplyConfiguration(new UserTokenConfiguration());
            builder.ApplyConfiguration(new RoleClaimConfiguration());
        }
    }

}
