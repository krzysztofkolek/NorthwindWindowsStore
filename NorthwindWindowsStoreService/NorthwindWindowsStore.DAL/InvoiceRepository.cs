namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class InvoiceRepository : BaseView<Invoice>
    {
        public InvoiceRepository(string path)
            : base(path)
        {
        }
    }
}
