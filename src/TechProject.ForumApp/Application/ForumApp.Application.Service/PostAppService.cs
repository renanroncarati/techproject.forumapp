using ForumApp.Application.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumApp.Domain.DataTransferObject;
using ForumApp.Core.Domain;
using ForumApp.Domain.Service.Interfaces;
using ForumApp.Core.Domain.Enum;

namespace ForumApp.Application.Service
{
    public class PostAppService : IPostAppService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PostAppService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(Post post)
        {
            using (_unitOfWork)
            {
                post.Created = DateTime.UtcNow;
                post.Status = PostStatus.Published;

                var entityPost = _mapper.Map<Core.Domain.Entities.Post>(post);
                _unitOfWork.PostRepository.Add(entityPost);

                _unitOfWork.Complete();
            }
        }

        public async Task<IEnumerable<Post>> GetAllAsync()
        {
            using (_unitOfWork)
            {
                return _mapper.Map<IEnumerable<Post>>(await _unitOfWork.PostRepository.GetAllAsync());
            }
        }

        public async Task<Post> GetAsync(int id)
        {
            using (_unitOfWork)
            {
                return _mapper.Map<Post>(await _unitOfWork.PostRepository.GetAsync(id));
            }
        }

        public void Remove(int id)
        {
            using (_unitOfWork)
            {
                var entityPost = _unitOfWork.PostRepository.Get(id);
                _unitOfWork.PostRepository.Remove(entityPost);

                _unitOfWork.Complete();
            }
        }
    }
}
