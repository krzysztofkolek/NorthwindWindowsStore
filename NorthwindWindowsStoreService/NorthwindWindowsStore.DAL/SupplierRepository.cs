namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class SupplierRepository : BaseRepository<Supplier>
    {
        public SupplierRepository(string path)
            : base(path)
        {
        }
    }
}
