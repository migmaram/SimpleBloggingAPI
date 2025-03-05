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
        public async void Add(TEntity data) => await _dbSet.AddAsync(data);

        public async void Delete(int id)
        {
            var toDelete = await _dbSet.FindAsync(id);
            _dbSet.Remove(toDelete);
        }

        public async Task<IEnumerable<TEntity>> Get() => await _dbSet.ToListAsync();

        public async Task<TEntity> Get(int id) => await _dbSet.FindAsync(id);

        public async void Save() => await _context.SaveChangesAsync();


        public void Update(TEntity data)
        {
            _dbSet.Attach(data);
            _context.Entry(data).State = EntityState.Modified;
        }
    }
}
