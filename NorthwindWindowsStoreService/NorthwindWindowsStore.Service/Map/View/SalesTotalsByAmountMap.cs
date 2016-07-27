
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class SalesTotalsByAmountMap : BaseMapper<Sales_Totals_by_Amount, SalesTotalsByAmountViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Sales_Totals_by_Amount, SalesTotalsByAmountViewModel>> GetConfig()
        {
            return new System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Sales_Totals_by_Amount, SalesTotalsByAmountViewModel>>(config =>
            {
                config.Bind(x => x.SaleAmount, o => o.SaleAmount);
                config.Bind(x => x.OrderID, o => o.OrderID);
                config.Bind(x => x.CompanyName, o => o.CompanyName);
                config.Bind(x => x.ShippedDate, o => o.ShippedDate);
            });
        }
    }
}
