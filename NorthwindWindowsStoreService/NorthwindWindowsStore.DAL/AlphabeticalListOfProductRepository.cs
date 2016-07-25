namespace NorthwindWindowsStore.DAL
{
    using NorthwindWindowsStore.DAL.Model;

    public class AlphabeticalListOfProductRepository : BaseView<Alphabetical_list_of_product>
    {
        public AlphabeticalListOfProductRepository(string path)
            : base(path)
        {
        }
    }
}
