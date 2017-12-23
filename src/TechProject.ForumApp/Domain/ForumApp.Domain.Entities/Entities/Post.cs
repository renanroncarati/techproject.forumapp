using ForumApp.Core.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Core.Domain.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public PostStatus Status { get; set; }

        public int UserId { get; set; }
        public int TopicId { get; set; }

        public virtual User User { get; set; }
        public virtual Topic Topic { get; set; }
    }    
}
