namespace NorthwindWindowsStore.ViewModel
{
    public class ShipperVM : BaseVM<ShipperViewModel>
    {
        public ShipperVM()
        {
        }

        public ShipperVM(ShipperViewModel model)
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
