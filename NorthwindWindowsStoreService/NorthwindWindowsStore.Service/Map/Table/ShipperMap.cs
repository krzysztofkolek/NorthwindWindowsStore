namespace NorthwindWindowsStore.Service.Map.Table
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class ShipperMap : BaseMapper<Shipper, ShipperViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Shipper, ShipperViewModel>> GetConfig()
        {
            return new System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Shipper, ShipperViewModel>>(config =>
            {
                config.Bind(x => x.ShipperID, o => o.ShipperID);
                config.Bind(x => x.CompanyName, o => o.CompanyName);
                config.Bind(x => x.Phone, o => o.Phone);

                config.Ignore(x => x.Orders);
            });
        }
    }
}
