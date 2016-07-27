
namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class SalesTotalsByAmountMap : BaseMapper<Sales_Totals_by_Amount, SalesTotalsByAmountViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Sales_Totals_by_Amount, SalesTotalsByAmountViewModel>> GetConfig()
        {
            throw new System.NotImplementedException();
        }
    }
}
