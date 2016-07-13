namespace NorthwindWindowsStore.DAL
{
    using Dapper;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public class BaseRepository<T>
        where T : class, new()
    {
        private SqLiteBaseRepository _baseRepository { get; set; }
        private IDbConnection _connection { get; set; }
        protected IDbConnection Connection
        {
            get
            {
                if (_baseRepository == null)
                {
                    _baseRepository = new SqLiteBaseRepository(_path);
                }

                if (_connection == null)
                {
                    _connection = _baseRepository.DbConnection();
                }

                return _connection;
            }
        }
        private String _path { get; set; }

        public BaseRepository(String applicationRunDirectory)
        {
            _path = applicationRunDirectory;
        }

        protected virtual String GetTableName()
        {
            return String.Format("{0}s", typeof(T).Name);
        }


        public virtual async Task<bool> Add(T item)
        {
            return false;
        }
        public virtual async Task<bool> Remove(T item)
        {
            return false;
        }

        public virtual async Task<bool> Update(T item)
        {
            return false;
        }

        public virtual async Task<T> FindByID(int id)
        {
            return null;
        }
        public virtual async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            return null;
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            using (IDbConnection db = Connection)
            {
                String query = String.Format("Select * From {0}", GetTableName());
                return db.Query<T>(query);
            }
            return null;
        }
    }
}
