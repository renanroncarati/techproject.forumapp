using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Infrastructure.DataTransferObject.Mappings
{
    public class PostMapping : Profile
    {
        public PostMapping()
        {
            CreateMap<Core.Domain.Entities.Post, Domain.DataTransferObject.Post>();
            CreateMap<Domain.DataTransferObject.Post, Core.Domain.Entities.Post>()
                .ForMember(dest => dest.Topic, opt => opt.Ignore())
                .ForMember(dest => dest.User, opt => opt.Ignore());
        }
    }
}
