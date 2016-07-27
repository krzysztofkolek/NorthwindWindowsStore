
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class CategorySalesFor1997Map : BaseMapper<Category_Sales_for_1997, CategorySalesFor1997ViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Category_Sales_for_1997, CategorySalesFor1997ViewModel>> GetConfig()
        {
            return new System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Category_Sales_for_1997, CategorySalesFor1997ViewModel>>(config => { });
        }
    }
}
