
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class SummaryOfSalesByYearMap : BaseMapper<Summary_of_Sales_by_Year, SummaryOfSalesByYearViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Summary_of_Sales_by_Year, SummaryOfSalesByYearViewModel>> GetConfig()
        {
            throw new System.NotImplementedException();
        }
    }
}
