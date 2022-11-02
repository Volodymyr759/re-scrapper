using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IRepository<TModel>
    {
        bool Create(TModel model);
        Task CreateAsync(TModel model);
        void Delete(TModel model);
        void DeleteAsync(TModel model);
        TModel Get(int id);
        TModel Get(Expression<Func<TModel, bool>> query);
        Task<TModel> GetAsync(int id);
        IEnumerable<TModel> GetAll();
        void Update(TModel model);
        void UpdateAsync(TModel model);
        IEnumerable<TModel> GetAll(Expression<Func<TModel, bool>> query = null, Func<IQueryable<TModel>, IOrderedQueryable<TModel>> orderBy = null);
        Task<IEnumerable<TModel>> GetAllAsync(Expression<Func<TModel, bool>> query = null, Func<IQueryable<TModel>, IOrderedQueryable<TModel>> orderBy = null);
    }
}
