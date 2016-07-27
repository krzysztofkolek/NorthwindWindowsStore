
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class CustomerAndSuppliersByCityMap : BaseMapper<Customer_and_Suppliers_by_City, CustomerAndSuppliersByCityViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Customer_and_Suppliers_by_City, CustomerAndSuppliersByCityViewModel>> GetConfig()
        {
            return new System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Customer_and_Suppliers_by_City, CustomerAndSuppliersByCityViewModel>>(config => { });
        }
    }
}
