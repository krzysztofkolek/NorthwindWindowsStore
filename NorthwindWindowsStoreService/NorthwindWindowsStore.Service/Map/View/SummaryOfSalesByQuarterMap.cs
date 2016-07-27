
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class SummaryOfSalesByQuarterMap : BaseMapper<Summary_of_Sales_by_Quarter, SummaryOfSalesByQuarterViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Summary_of_Sales_by_Quarter, SummaryOfSalesByQuarterViewModel>> GetConfig()
        {
            return new System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Summary_of_Sales_by_Quarter, SummaryOfSalesByQuarterViewModel>>(config =>
            {
                config.Bind(x => x.OrderID, o => o.OrderID);
                config.Bind(x => x.ShippedDate, o => o.ShippedDate);
                config.Bind(x => x.Subtotal, o => o.Subtotal);
            });
        }
    }
}
