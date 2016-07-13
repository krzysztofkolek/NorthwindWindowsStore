namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class TerritoryRepository : BaseRepository<Territory>
    {
        public TerritoryRepository(string path)
            : base(path)
        {
        }
    }
}
