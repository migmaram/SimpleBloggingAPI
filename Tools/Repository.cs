using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SimpleBloggingAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private ApiDbContext _context;
        private DbSet<TEntity> _dbSet;
        public Repository(ApiDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public void Add(TEntity data) =>  _dbSet.Add(data);

        public void Delete(int id)
        {
            var toDelete = _dbSet.Find(id);
            _dbSet.Remove(toDelete);
        }

        public IEnumerable<TEntity> Get() => _dbSet.ToList();

        public TEntity Get(int id) =>  _dbSet.Find(id);

        public void Save() =>  _context.SaveChanges();


        public void Update(TEntity data)
        {
            _dbSet.Attach(data);
            _context.Entry(data).State = EntityState.Modified;
        }
    }
}
