namespace NorthwindWindowsStore.ViewModel
{
    using System;
    using System.IO;
    using Windows.Storage.Streams;
    using Windows.UI.Xaml.Media.Imaging;

    public class EmployeeVM : BaseVM<EmployeeViewModel>
    {
        public EmployeeVM()
        {
        }

        public EmployeeVM(EmployeeViewModel model)
        {
            Member.EmployeeID = model.EmployeeID;
            Member.LastName = model.LastName;
            Member.FirstName = model.FirstName;
            Member.Title = model.Title;
            Member.TitleOfCourtesy = model.TitleOfCourtesy;
            Member.BirthDate = model.BirthDate;
            Member.HireDate = model.HireDate;
            Member.Address = model.Address;
            Member.City = model.City;
            Member.Region = model.Region;
            Member.PostalCode = model.PostalCode;
            Member.Country = model.Country;
            Member.HomePhone = model.HomePhone;
            Member.Extension = model.Extension;
            Member.Photo = model.Photo;
            Member.Notes = model.Notes;
            Member.ReportsTo = model.ReportsTo;
            Member.PhotoPath = model.PhotoPath;
        }

        #region Concreate type setters
        public String FirstName
        {
            set
            {
                Member.FirstName = value;
            }
        }

        public String LastName
        {
            set
            {
                Member.LastName = value;
            }
        }
        #endregion Concreate type setters

        #region VM Access Properties
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

        public byte[] Photo
        {
            get
            {
                return Member.Photo;
            }
        }

        public BitmapImage LoadedPhoto
        {
            get
            {
                var value = Photo;
                if (value == null || !(value is byte[]))
                    return null;

                using (InMemoryRandomAccessStream stream = new InMemoryRandomAccessStream())
                {
                    using (DataWriter writer = new DataWriter(stream.GetOutputStreamAt(0)))
                    {
                        writer.WriteBytes((byte[])value);
                        writer.StoreAsync().GetResults();
                    }
                    BitmapImage image = new BitmapImage();
                    image.DecodePixelHeight = 170;
                    image.DecodePixelWidth = 160;
                    image.SetSource(stream);
                    return image;
                }
            }
        }
        #endregion VM Access Properties
    }
}
