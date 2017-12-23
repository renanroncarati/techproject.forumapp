using ForumApp.Core.Domain;
using ForumApp.Core.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ForumApp.Infrasctructure.EntityFramework.Repositories
{
    public class TopicRepository : Repository<Topic>, ITopicRepository
    {
        public TopicRepository(DbContext context) : base(context)
        {
        }
    }
}
