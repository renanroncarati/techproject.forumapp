using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Infrastructure.DataTransferObject.Mappings
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<Core.Domain.Entities.User, Domain.DataTransferObject.User>();
            CreateMap<Domain.DataTransferObject.User, Core.Domain.Entities.User>()
                .ForMember(dest => dest.Posts, opt => opt.Ignore())
                .ForMember(dest => dest.Topics, opt => opt.Ignore());
        }
    }
}
