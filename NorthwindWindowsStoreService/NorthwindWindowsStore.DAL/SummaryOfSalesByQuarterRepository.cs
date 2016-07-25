namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class SummaryOfSalesByQuarterRepository : BaseView<Summary_of_Sales_by_Quarter>
    {
        public SummaryOfSalesByQuarterRepository(string path)
            : base(path)
        {
        }
    }
}
