using ForumApp.Domain.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Application.Service.Interfaces
{
    public interface IPostAppService
    {
        Task<Post> GetAsync(int id);
        Task<IEnumerable<Post>> GetAllAsync();
        void Add(Post post);
        void Remove(int id);
    }
}
