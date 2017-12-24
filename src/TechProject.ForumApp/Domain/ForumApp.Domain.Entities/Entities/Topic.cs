using ForumApp.Core.Domain.Enum;
using System;
using System.Collections.Generic;

namespace ForumApp.Core.Domain.Entities
{
    public class Topic
    {
        public Topic()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdate { get; set; }
        public TopicStatus Status { get; set; }
        public TopicCategory Category { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }    
}
