namespace NorthwindWindowsStore.ViewModel
{
    public class SupplierGridVM : BaseVM<SupplierViewModel>
    {
        public SupplierGridVM()
        { }

        public SupplierGridVM(SupplierViewModel model)
        {
            Member.SupplierID = model.SupplierID;
            Member.CompanyName = model.CompanyName;
            Member.ContactName = model.ContactName;
            Member.ContactTitle = model.ContactTitle;
            Member.Address = model.Address;
            Member.City = model.City;
            Member.Region = model.Region;
            Member.PostalCode = model.PostalCode;
            Member.Country = model.Country;
            Member.Phone = model.Phone;
            Member.Fax = model.Fax;
            Member.HomePage = model.HomePage;
        }


        public string ComapnyName
        {
            get
            {
                return Member.CompanyName;
            }
        }

        public string Contact
        {
            get
            {
                return Member.ContactName;
            }
        }

        public string Address
        {
            get { return Member.Address; }
        }
    }
}
