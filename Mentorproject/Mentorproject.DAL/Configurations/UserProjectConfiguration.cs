using Mentorproject.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mentorproject.DAL.Configurations
{
    public class UserProjectConfiguration: IEntityTypeConfiguration<UserProject>
    {
        public void Configure(EntityTypeBuilder<UserProject> builder)
        {
            builder.HasKey(p => new { p.UserId, p.ProjectId });

            builder.HasOne<User>(x => x.User)
                .WithMany(p => p.UserProjects)
                .HasForeignKey(p => p.UserId);

            builder.HasOne<Project>(x => x.Project)
                .WithMany(x => x.UserProjects)
                .HasForeignKey(x => x.ProjectId);
        }
    }
}
