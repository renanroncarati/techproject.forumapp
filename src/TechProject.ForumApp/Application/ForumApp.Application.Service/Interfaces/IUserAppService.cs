using ForumApp.Domain.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Application.Service.Interfaces
{
    public interface IUserAppService
    {
        Task<User> GetAsync(int id);
        void Add(User user);
        void Remove(int id);
    }
}
