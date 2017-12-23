using ForumApp.Core.Domain.Repositories;
using System;

namespace ForumApp.Core.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        ITopicRepository TopicRepository { get; }
        IPostRepository PostRepository { get; }
        IUserRepository UserRepository { get; }

        //it is preferreble than Save
        int Complete();
    }
}
