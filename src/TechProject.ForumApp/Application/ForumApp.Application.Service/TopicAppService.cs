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
    public class TopicAppService : ITopicAppService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TopicAppService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(Topic topic)
        {
            using (_unitOfWork)
            {
                topic.Created = DateTime.UtcNow;
                topic.LastUpdate = DateTime.UtcNow;
                topic.Status = TopicStatus.Active;                

                var entityTopic = _mapper.Map<Core.Domain.Entities.Topic>(topic);
                _unitOfWork.TopicRepository.Add(entityTopic);

                _unitOfWork.Complete();
            }
        }

        public async Task<IEnumerable<Topic>> GetAllAsync()
        {
            using (_unitOfWork)
            {
                return _mapper.Map<IEnumerable<Topic>>(await _unitOfWork.TopicRepository.GetAllAsync());
            }
        }

        public async Task<Topic> GetAsync(int id)
        {
            using (_unitOfWork)
            {
                return _mapper.Map<Topic>(await _unitOfWork.TopicRepository.GetAsync(id));
            }
        }

        public void Remove(int id)
        {
            using (_unitOfWork)
            {
                var entityTopic = _unitOfWork.TopicRepository.Get(id);
                _unitOfWork.TopicRepository.Remove(entityTopic);

                _unitOfWork.Complete();
            }
        }
    }
}
