using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Domain.Service.Interfaces
{
    public interface IMapper
    {
        TTarget Map<TTarget>(object source);
    }
}
