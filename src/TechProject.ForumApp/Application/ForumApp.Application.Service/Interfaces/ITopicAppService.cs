using ForumApp.Domain.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Application.Service.Interfaces
{
    public interface ITopicAppService
    {
        Task<Topic> GetAsync(int id);
        Task<IEnumerable<Topic>> GetAllAsync();
        void Add(Topic topic);
        void Remove(int id);
    }
}
