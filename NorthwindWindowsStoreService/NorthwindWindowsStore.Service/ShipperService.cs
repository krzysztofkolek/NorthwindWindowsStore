namespace NorthwindWindowsStore.Service
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class ShipperService : BaseService<Shipper, ShipperViewModel>
    {
        public ShipperService(string path)
            : base(path)
        {
        }
    }
}
