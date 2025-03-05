using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    internal interface IRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> Get();
        Task<TEntity> Get(int id);
        void Add(TEntity data);
        void Delete(int id);
        void Update(TEntity data);
        void Save();
    }
}
