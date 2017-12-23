using ForumApp.Application.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumApp.Domain.DataTransferObject;
using ForumApp.Core.Domain;
using ForumApp.Domain.Service.Interfaces;

namespace ForumApp.Application.Service
{
    public class UserAppService : IUserAppService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserAppService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(User user)
        {
            using (_unitOfWork)
            {
                var entityUser = _mapper.Map<Core.Domain.Entities.User>(user);
                _unitOfWork.UserRepository.Add(entityUser);

                _unitOfWork.Complete();
            }
        }

        public void Remove(int id)
        {
            using (_unitOfWork)
            {
                var entityUser = _unitOfWork.UserRepository.Get(id);
                _unitOfWork.UserRepository.Remove(entityUser);

                _unitOfWork.Complete();
            }
        }

        public async Task<User> GetAsync(int id)
        {
            using (_unitOfWork)
            {
                return _mapper.Map<User>(await _unitOfWork.UserRepository.GetAsync(id));
            }
        }
    }
}
