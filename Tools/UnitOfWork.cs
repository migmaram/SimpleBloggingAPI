using Microsoft.EntityFrameworkCore;
using SimpleBloggingAPI.Data;
using SimpleBloggingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    internal class UnitOfWork : IUnitOfWork
    {
        private ApiDbContext _context;
        private IRepository<Post>? _posts;
        private IRepository<Category>? _categories;
        private IRepository<Tag>? _tags;

        public IRepository<Post> Posts
        {
            get
            {
                return _posts ?? new Repository<Post>(_context);
            }
        }

        public IRepository<Category> Categories
        {
            get
            {
                return _categories ?? new Repository<Category>(_context);
            }
        }

        public IRepository<Tag> Tags
        {
            get
            {
                return _tags ?? new Repository<Tag>(_context);
            }
        }
        public UnitOfWork(ApiDbContext context)
        {
            _context = context;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
