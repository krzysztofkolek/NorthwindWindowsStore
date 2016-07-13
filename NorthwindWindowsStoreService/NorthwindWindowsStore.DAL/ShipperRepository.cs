namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class ShipperRepository : BaseRepository<Shipper>
    {
        public ShipperRepository(string path)
            : base(path)
        {
        }
    }
}
