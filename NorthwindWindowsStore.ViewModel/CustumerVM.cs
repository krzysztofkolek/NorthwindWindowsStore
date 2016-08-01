namespace NorthwindWindowsStore.ViewModel
{
    public class CustumerVM : BaseVM<CustomerViewModel>
    {
        public CustumerVM()
        {
        }

        public CustumerVM(CustomerViewModel model)
        {
            Member.CustomerID = model.CustomerID;
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
        }

        public string CompanyName
        {
            get
            {
                return Member.CompanyName;
            }
        }
        public string ContactName
        {
            get
            {
                return Member.ContactName;
            }
        }
        public string ContactTitle
        {
            get
            {
                return Member.ContactTitle;
            }
        }
        public string Phone
        {
            get
            {
                return Member.Phone;
            }
        }
        public string Address
        {
            get
            {
                return string.Format("{0}", Member.Address);
            }
        }
    }
}
