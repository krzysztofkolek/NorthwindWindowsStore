using System;
namespace NorthwindWindowsStore.Service.Map
{
    public abstract class BaseMapper<I, O>
        where I : class, new()
        where O : class, new()
    {
        public BaseMapper()
        {
        }

        public abstract Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<I, O>> GetConfig();
    }
}
