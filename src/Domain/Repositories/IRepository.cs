using System.Linq;

namespace ShaBoo.Domain.Repositories
{
    /// <summary>
    /// CRUD
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        // Create
        void Insert(TEntity entity);

        // Read 
        IQueryable<TEntity> GetAll();

        TEntity GetByID(object id);

        // Update
        // In very complex scenarios with big object graphs you will probably give up
        // using detached approach and you will always load your entities from DB before
        // deleting or updating them. In such case you will not need Update method at all.
        //在非常复杂的场景中，含有大型对象图，或许会放弃使用分离步骤，而是在删除更新之间总会
        //加载实体。这种情况就无须Update方法。
        //note:看不懂 ;-(
        void Update(TEntity entityToUpdate);

        // Delete
        void Delete(object id);

        void Delete(TEntity entityToDelete);

        //IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters);
    }
}