using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Infrastructure.DataTransferObject.Mappings
{
    public class TopicMapping : Profile
    {
        public TopicMapping()
        {
            CreateMap<Core.Domain.Entities.Topic, Domain.DataTransferObject.Topic>();
            CreateMap<Domain.DataTransferObject.Topic, Core.Domain.Entities.Topic>()
                .ForMember(dest => dest.Posts, opt => opt.Ignore())
                .ForMember(dest => dest.User, opt => opt.Ignore())
                .ForMember(dest => dest.UserId, opt => opt.Ignore());
        }
    }
}
