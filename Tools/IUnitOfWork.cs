using SimpleBloggingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public interface IUnitOfWork
    {
        public IRepository<Post> Posts { get; }
        public void Save();
    }
}

