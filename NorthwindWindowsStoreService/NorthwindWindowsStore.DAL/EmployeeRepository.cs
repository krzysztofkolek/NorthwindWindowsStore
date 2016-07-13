namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class EmployeeRepository : BaseRepository<Employee>
    {
        public EmployeeRepository(string path)
            : base(path)
        {
        }
    }
}
