using System.Data;

namespace Data
{
    public interface IRepository<T> {
        T Get(int id);

        bool Insert(T entity);

        bool Update(T entity);

        bool Delete(T entity);

    }

    public abstract class SqlRepository<T> : IRepository<T> {
        protected IDbConnection connection;

        public SqlRepository(IDbConnection connection) {
            this.connection = connection;
        }

        public virtual T Get(int id) {
            throw new System.NotImplementedException();
        }

        public virtual bool Insert(T entity) {
            throw new System.NotImplementedException();
        }

        public virtual bool Update(T entity) {
            throw new System.NotImplementedException();
        }

        public virtual bool Delete(T entity) {
            throw new System.NotImplementedException();
        }
    }
}
