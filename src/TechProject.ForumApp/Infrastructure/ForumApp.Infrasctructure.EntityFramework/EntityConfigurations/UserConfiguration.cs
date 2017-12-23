using ForumApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Infrasctructure.EntityFramework.EntityConfigurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("Users")
                .HasKey(u => u.Id);

            Property(u => u.Login)
                .HasMaxLength(100)
                .IsUnicode(false);

            Property(u => u.Password)
                .HasMaxLength(100)
                .IsUnicode(false);

            Property(u => u.Email)
                .HasMaxLength(100)          
                .IsUnicode(false);

        }
    }
}
