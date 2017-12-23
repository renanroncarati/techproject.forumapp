using ForumApp.Core.Domain.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumApp.Infrasctructure.EntityFramework.EntityConfigurations;
using ForumApp.Core.Domain.Entities;

namespace ForumApp.Infrasctructure.EntityFramework
{
    public class ForumAppContext : DbContext
    {
        #region DbSet
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<User> Users { get; set; }
        #endregion

        public ForumAppContext()
            : base("name=ForumAppContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PostConfiguration());
            modelBuilder.Configurations.Add(new TopicConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());

        }        
    }
}
