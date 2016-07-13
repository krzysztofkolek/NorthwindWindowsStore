namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(string path)
            : base(path)
        {
        }
    }
}
