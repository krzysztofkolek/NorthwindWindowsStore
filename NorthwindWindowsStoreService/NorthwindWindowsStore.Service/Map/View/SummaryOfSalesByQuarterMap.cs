
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class SummaryOfSalesByQuarterMap : BaseMapper<Summary_of_Sales_by_Quarter, SummaryOfSalesByQuarterViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Summary_of_Sales_by_Quarter, SummaryOfSalesByQuarterViewModel>> GetConfig()
        {
            throw new System.NotImplementedException();
        }
    }
}
