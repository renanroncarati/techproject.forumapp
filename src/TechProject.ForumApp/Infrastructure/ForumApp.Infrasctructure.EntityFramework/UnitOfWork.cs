using ForumApp.Core.Domain;
using ForumApp.Core.Domain.Repositories;
using ForumApp.Infrasctructure.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Infrasctructure.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ForumAppContext _context;

        public UnitOfWork(ForumAppContext context)
        {
            _context = context;

            TopicRepository = new TopicRepository(_context);
            PostRepository = new PostRepository(_context);
            UserRepository = new UserRepository(_context);
        }

        #region Repositories
        public ITopicRepository TopicRepository { get; private set; }
        public IPostRepository PostRepository { get; private set; }
        public IUserRepository UserRepository { get; private set; }
        #endregion

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
