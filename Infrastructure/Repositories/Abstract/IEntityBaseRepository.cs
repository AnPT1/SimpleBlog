using MiniBlog2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MiniBlog2.Infrastructure.Repositories
{
    /// <summary>
    /// Contract for an entity which is treated like repository
    /// </summary>
    /// <typeparam name="T"> db entity</typeparam>
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        #region Get a collection

        IQueryable<T> Query();

        IQueryable<T> Query(Expression<Func<T, bool>> predicate,params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> Query(Expression<Func<T, bool>> predicate);

        IQueryable<T> QueryInclude(params Expression<Func<T, object>>[] includeProperties);


        IEnumerable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);

        Task<IEnumerable<T>> AllIncludingAsync(params Expression<Func<T, object>>[] includeProperties);

        IEnumerable<T> GetAll();

        Task<IEnumerable<T>> GetAllAsync();

        #endregion

        #region Get a single entity

        T GetSingle(int id);

        T GetSingle(Expression<Func<T, bool>> predicate);

        T GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        Task<T> GetSingleAsync(int id);

        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);

        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> predicate);

        #endregion

        #region CRUD & commit

        void Add(T entity);

        void Delete(T entity);

        void Edit(T entity);

        void Commit();

        #endregion

    }
}
