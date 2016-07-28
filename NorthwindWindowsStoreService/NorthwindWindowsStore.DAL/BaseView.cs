namespace NorthwindWindowsStore.DAL
{
    using Dapper;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading.Tasks;

    public class BaseView<T>
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

        public BaseView(String applicationRunDirectory)
        {
            _path = applicationRunDirectory;
        }

        protected virtual String GetViewName()
        {
            return String.Format("{0}", typeof(T).Name);
        }

        public virtual async Task<IEnumerable<T>> GetViewResult()
        {
            using (IDbConnection db = Connection)
            {
                String query = String.Format("Select * From {0}", GetViewName());
                return db.Query<T>(query);
            }
            return null;
        }
    }
}
