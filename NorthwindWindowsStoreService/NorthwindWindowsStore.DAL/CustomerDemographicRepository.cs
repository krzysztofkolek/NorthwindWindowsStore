namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class CustomerDemographicRepository : BaseRepository<CustomerDemographic>
    {
        public CustomerDemographicRepository(string path)
            : base(path)
        {
        }
    }
}
