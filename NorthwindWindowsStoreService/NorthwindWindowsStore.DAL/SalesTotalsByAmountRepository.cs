namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class SalesTotalsByAmountRepository : BaseRepository<Sales_Totals_by_Amount>
    {
        public SalesTotalsByAmountRepository(string path)
            : base(path)
        {
        }
    }
}
