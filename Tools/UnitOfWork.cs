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

        public IRepository<Post> Posts
        {
            get
            {
                return _posts ?? new Repository<Post>(_context);
            }
        }

        public UnitOfWork(ApiDbContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
