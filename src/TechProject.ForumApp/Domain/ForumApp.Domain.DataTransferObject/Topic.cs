using ForumApp.Core.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Domain.DataTransferObject
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdate { get; set; }
        public TopicStatus Status { get; set; }
        public TopicCategory Category { get; set; }
        public int UserId { get; set; }
    }
}
