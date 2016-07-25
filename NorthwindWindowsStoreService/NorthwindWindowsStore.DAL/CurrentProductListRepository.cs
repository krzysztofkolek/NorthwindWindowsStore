namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class CurrentProductListRepository : BaseView<Current_Product_List>
    {
        public CurrentProductListRepository(string path)
            : base(path)
        {
        }
    }
}
