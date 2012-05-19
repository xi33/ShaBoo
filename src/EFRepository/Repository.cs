using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using ShaBoo.Domain.Repositories;
using ShaBoo.Entities;

namespace ShaBoo.EFRepositories
{
    public class SortExpression<TEntity, TType>
    {
        Expression<Func<TEntity, TType>> _sortProperty;
    }

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        // 是否需要解耦Context，天哪，做什么事都不要太过，毕竟我是一个人在战斗。
        // 写程序最忌考虑太周到，没错，快速原型开发模式。
        public Repository()
        {
            Context = new ShaBooContainer();
        }

        public Repository(ShaBooContainer context)
        {
            Context = context;
        }

        protected ShaBooContainer Context = null;

        protected DbSet<TEntity> DbSet
        {
            get { return Context.Set<TEntity>(); }
        }

        public IQueryable<TEntity> GetAll(
            )
        {
            IQueryable<TEntity> query = DbSet;
            return query;
        }

        public TEntity GetByID(object id)
        {
            return DbSet.Find(id);
        }

        public void Insert(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void Delete(object id)
        {
            TEntity entityToDelete = DbSet.Find(id);
            Delete(entityToDelete);
        }

        public void Delete(TEntity entityToDelete)
        {
            if (Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);
            }
            DbSet.Remove(entityToDelete);
        }

        public void Update(TEntity entityToUpdate)
        {
            DbSet.Attach(entityToUpdate);
            Context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        //public IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters)
        //{
        //    return DbSet.SqlQuery(query, parameters).ToList();
        //}
    }
}
