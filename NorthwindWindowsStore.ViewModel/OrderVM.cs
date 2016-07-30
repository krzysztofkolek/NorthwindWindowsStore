
namespace NorthwindWindowsStore.ViewModel
{

    public class OrderVM : BaseVM<OrderViewModel>
    {
        public OrderVM()
        { }

        public OrderVM(OrderViewModel model)
        {
            Member.OrderID = model.OrderID;
            Member.CustomerID = model.CustomerID;
            Member.EmployeeID = model.EmployeeID;
            Member.OrderDate = model.OrderDate;
            Member.RequiredDate = model.RequiredDate;
            Member.ShippedDate = model.ShippedDate;
            Member.ShipVia = model.ShipVia;
            Member.Freight = model.Freight;
            Member.ShipName = model.ShipName;
            Member.ShipAddress = model.ShipAddress;
            Member.ShipCity = model.ShipCity;
            Member.ShipRegion = model.ShipRegion;
            Member.ShipPostalCode = model.ShipPostalCode;
            Member.ShipCountry = model.ShipCountry;
        }

        public string Customer
        {
            get
            {
                return Member.CustomerID;
            }
        }


        public string OrderShipAdress
        {
            get
            {
                return string.Format("{0}", Member.ShipAddress);
            }
        }

        public string ShippedDate
        {
            get
            {
                if (Member.ShippedDate.HasValue)
                    return Member.ShippedDate.Value.ToString();
                return "";
            }
        }
        public string RequiredDate
        {
            get
            {
                if (Member.RequiredDate.HasValue)
                    return Member.RequiredDate.Value.ToString();
                return "";
            }
        }
    }
}
