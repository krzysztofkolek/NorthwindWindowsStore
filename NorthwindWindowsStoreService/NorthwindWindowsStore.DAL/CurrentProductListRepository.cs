namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class CurrentProductListRepository : BaseRepository<Current_Product_List>
    {
        public CurrentProductListRepository(string path)
            : base(path)
        {
        }
    }
}
