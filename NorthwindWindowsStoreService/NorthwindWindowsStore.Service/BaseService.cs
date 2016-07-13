namespace NorthwindWindowsStore.Service
{
    using NorthwindWindowsStore.DAL;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="I">Input - DAL model</typeparam>
    /// <typeparam name="O">Output - ViewModel</typeparam>
    public abstract class BaseService<I, O>
        where I : class, new()
        where O : class, new()
    {
        private BaseRepository<I> _repository;

        public BaseService(String applicationRunDirectory)
        {
            _repository = new BaseRepository<I>(applicationRunDirectory);
        }

        protected O TransformObject(I input)
        {
            return null;
        }

        protected IEnumerable<O> TranformList(IEnumerable<I> inputList)
        {
            foreach (var genericListem in inputList)
            {
                yield return TransformObject(genericListem);
            }
        }

        public async void Add(I item)
        {
            await _repository.Add(item);
        }

        public async void Remove(I item)
        {
            _repository.Remove(item);
        }

        public async void Update(I item)
        {
            _repository.Update(item);
        }

        public async Task<O> FindByID(int id)
        {
            return TransformObject(_repository.FindByID(id).Result);
        }
        public async Task<IEnumerable<O>> Find(Expression<Func<I, bool>> predicate)
        {
            return TranformList(_repository.Find(predicate).Result);
        }

        public async Task<IEnumerable<O>> GetAll()
        {
            return TranformList(_repository.GetAll().Result);
        }
    }
}
