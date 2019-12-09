using Mentorproject.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mentorproject.DAL.Configurations
{
    public class RespectConfiguration : IEntityTypeConfiguration<Respect>
    {
        public void Configure(EntityTypeBuilder<Respect> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
