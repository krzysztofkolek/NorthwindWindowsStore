namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class SummaryOfSalesByYearRepository : BaseRepository<Summary_of_Sales_by_Year>
    {
        public SummaryOfSalesByYearRepository(string path)
            : base(path)
        {
        }
    }
}
