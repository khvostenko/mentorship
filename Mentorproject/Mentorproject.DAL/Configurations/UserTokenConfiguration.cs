using Mentorproject.DAL.Entities.Identities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mentorproject.DAL.Configurations
{
    public class UserTokenConfiguration: IEntityTypeConfiguration<UserToken>
    {
        public void Configure(EntityTypeBuilder<UserToken> builder)
        {
            builder.HasKey(x => new { x.UserId, x.LoginProvider, x.Name });
        }
    }
}
