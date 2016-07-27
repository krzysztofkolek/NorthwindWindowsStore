namespace NorthwindWindowsStore.Service.Map.View
{
    using NorthwindWindowsStore.DAL.Model;
    using NorthwindWindowsStore.ViewModel;

    public class AlphabeticalListOfProductMap : BaseMapper<Alphabetical_list_of_product, AlphabeticalListOfProductViewModel>
    {
        public override System.Action<Nelibur.ObjectMapper.Bindings.IBindingConfig<Alphabetical_list_of_product, AlphabeticalListOfProductViewModel>> GetConfig()
        {
            throw new System.NotImplementedException();
        }
    }
}
