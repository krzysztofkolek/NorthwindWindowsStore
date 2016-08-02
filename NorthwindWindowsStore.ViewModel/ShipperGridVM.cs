namespace NorthwindWindowsStore.ViewModel
{
    public class ShipperGridVM: BaseVM<ShipperViewModel>
    {
        public ShipperGridVM()
        {
        }

        public ShipperGridVM(ShipperViewModel model)
        {
            Member.ShipperID = model.ShipperID;
            Member.CompanyName = model.CompanyName;
            Member.Phone = model.Phone;
        }

        public string CompanyName
        {
            get
            {
                return Member.CompanyName;
            }
        }
        public string Phone
        {
            get
            {
                return Member.Phone;
            }
        }
    }
    
}
