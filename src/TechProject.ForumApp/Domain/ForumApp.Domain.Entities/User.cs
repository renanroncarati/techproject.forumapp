using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Core.Domain
{
    public class User
    {
        public User()
        {
            Posts = new HashSet<Post>();
            Topics = new HashSet<Topic>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }

    }
}
