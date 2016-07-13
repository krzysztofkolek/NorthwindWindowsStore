namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class InvoiceRepository : BaseRepository<Invoice>
    {
        public InvoiceRepository(string path)
            : base(path)
        {
        }
    }
}
