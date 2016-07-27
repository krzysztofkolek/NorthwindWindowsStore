
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class InvoiceMap : BaseMapper<Invoice, InvoiceViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Invoice, InvoiceViewModel>> GetConfig()
        {
            throw new System.NotImplementedException();
        }
    }
}
