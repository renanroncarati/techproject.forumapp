using ForumApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Infrasctructure.EntityFramework.EntityConfigurations
{
    public class PostConfiguration : EntityTypeConfiguration<Post>
    {
        public PostConfiguration()
        {
            ToTable("Posts")
                .HasKey(p => p.Id);

            Property(p => p.Title)
                .HasMaxLength(200)
                .IsUnicode(false);

            HasRequired(p => p.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(u => u.UserId)
                .WillCascadeOnDelete(false);

            HasRequired(p => p.Topic)
                .WithMany(t => t.Posts)
                .HasForeignKey(t => t.TopicId)
                .WillCascadeOnDelete(false);
        }
    }
}
