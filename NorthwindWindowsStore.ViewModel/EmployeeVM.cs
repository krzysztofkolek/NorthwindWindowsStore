namespace NorthwindWindowsStore.ViewModel
{
    using System;

    public class EmployeeVM : BaseVM<EmployeeViewModel>
    {
        public String FullName
        {
            get
            {
                return String.Format("{0} {1}", Member.FirstName, Member.LastName);
            }
        }

        public String Title
        {
            get
            {
                return Member.Title;
            }
        }

        public String FullAdress
        {
            get
            {
                return String.Format("{0} {1} {2} {3}", Member.Country,
                                                        Member.Address,
                                                        Member.City,
                                                        Member.PostalCode);
            }
        }

        public String ShortAdress
        {
            get
            {
                return String.Format("{0} {1}", Member.Address,
                                                Member.City);
            }
        }

        public String Notes
        {
            get
            {
                return Member.Notes;
            }
        }
    }
}
