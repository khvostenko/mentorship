using Mentorproject.DAL.Configurations;
using Mentorproject.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Mentorproject.DAL.Context
{
    public class ApplicationContext:AuthContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Respect> Respects { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<UserProject> UserProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProjectConfiguration());
            builder.ApplyConfiguration(new PositionConfiguration());
            builder.ApplyConfiguration(new RespectConfiguration());
            builder.ApplyConfiguration(new TechnologyConfiguration());
            builder.ApplyConfiguration(new UserProjectConfiguration());
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
