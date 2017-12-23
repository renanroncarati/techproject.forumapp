using ForumApp.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Infrasctructure.EntityFramework.EntityConfigurations
{
    public class TopicConfiguration : EntityTypeConfiguration<Topic>
    {
        public TopicConfiguration()
        {
            ToTable("Topics")
                .HasKey(t => t.Id);

            Property(t => t.Title)
                .HasMaxLength(200)
                .IsUnicode(false);

            HasRequired(t => t.User)
                .WithMany(u => u.Topics)
                .WillCascadeOnDelete(false);
        }
    }
}
