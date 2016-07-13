namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class RegionRepository : BaseRepository<Region>
    {
        public RegionRepository(string path)
            : base(path)
        {
        }
    }
}
