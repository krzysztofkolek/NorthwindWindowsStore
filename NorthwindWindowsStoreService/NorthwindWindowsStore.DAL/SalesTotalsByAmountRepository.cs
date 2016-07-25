namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class SalesTotalsByAmountRepository : BaseView<Sales_Totals_by_Amount>
    {
        public SalesTotalsByAmountRepository(string path)
            : base(path)
        {
        }
    }
}
