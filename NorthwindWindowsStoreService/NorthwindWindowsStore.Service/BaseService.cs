namespace NorthwindWindowsStore.Service
{
    using Nelibur.ObjectMapper;
    using NorthwindWindowsStore.DAL;
    using NorthwindWindowsStore.DAL.Model.Interface;
    using NorthwindWindowsStore.Service.Map;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    /// <summary>
    /// Base service provided for services
    /// </summary>
    /// <typeparam name="I">Input - DAL model</typeparam>
    /// <typeparam name="O">Output - ViewModel</typeparam>
    public abstract class BaseService<I, O>
        where I : class, new()
        where O : class, new()
    {
        private BaseRepository<I> _repository { get; set; }
        private BaseView<I> _view { get; set; }
        private static bool MapperIsntSet = true;

        public BaseService(String applicationRunDirectory)
        {
            List<Type> interfaces = new List<Type>();
            interfaces.AddRange(typeof(I).GetInterfaces() as Type[]);

            if (interfaces.Contains(typeof(ITable)))
            {
                _repository = new BaseRepository<I>(applicationRunDirectory);
            }
            else if (interfaces.Contains(typeof(IView)))
            {
                _view = new BaseView<I>(applicationRunDirectory);
            }

            if (MapperIsntSet)
            {
                MapperIsntSet = false;
                TinyMapperStaticConfiguration.SetTinyMapperStaticConfiguration();
            }
        }

        protected O TransformObject(I input)
        {
            return TinyMapper.Map<O>(input);
        }

        protected IEnumerable<O> TranformList(IEnumerable<I> inputList)
        {
            foreach (var genericListem in inputList)
            {
                yield return TransformObject(genericListem);
            }
        }

        public async Task<bool> Add(I item)
        {
            if (_repository != null)
            {
                return false;
            }
            return await _repository.Add(item);
        }

        public async Task<bool> Remove(I item)
        {
            if (_repository == null)
            {
                return false;
            }
            return await _repository.Remove(item);
        }

        public async Task<bool> Update(I item)
        {
            if (_repository == null)
            {
                return false;
            }
            return await _repository.Update(item);
        }

        public async Task<O> FindByID(int id)
        {
            return TransformObject(_repository.FindByID(id).Result);
        }
        public async Task<IEnumerable<O>> Find(Expression<Func<I, bool>> predicate)
        {
            return TranformList(_repository.Find(predicate).Result);
        }

        public IEnumerable<O> GetAll()
        {
            var result = _repository.GetAll();
            return TranformList(result);
        }

        public async Task<IEnumerable<O>> GetViewResult()
        {
            return TranformList(_view.GetViewResult().Result);
        }
    }
}
