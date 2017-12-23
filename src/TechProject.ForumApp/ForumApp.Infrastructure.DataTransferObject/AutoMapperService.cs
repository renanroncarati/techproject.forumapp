using ForumApp.Domain.Service.Interfaces;

namespace ForumApp.Infrastructure.DataTransferObject
{
    public class AutoMapperService : IMapper
    {
        public TTarget Map<TTarget>(object source)
        {
            return AutoMapper.Mapper.Map<TTarget>(source);
        }
    }
}
