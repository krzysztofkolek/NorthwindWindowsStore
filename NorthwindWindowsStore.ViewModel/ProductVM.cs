
namespace NorthwindWindowsStore.ViewModel
{

    public class ProductVM : BaseVM<ProductViewModel>
    {
        public ProductVM()
        { }

        public ProductVM(ProductViewModel model)
        {
            Member.ProductID = model.ProductID;
            Member.ProductName = model.ProductName;
            Member.SupplierID = model.SupplierID;
            Member.CategoryID = model.CategoryID;
            Member.QuantityPerUnit = model.QuantityPerUnit;
            Member.UnitPrice = model.UnitPrice;
            Member.UnitsInStock = model.UnitsInStock;
            Member.UnitsOnOrder = model.UnitsOnOrder;
            Member.ReorderLevel = model.ReorderLevel;
            Member.Discontinued = model.Discontinued;

        }

        public string ProductName
        {
            get
            {
                return Member.ProductName;
            }
        }

        public decimal UnitPrice
        {
            get
            {
                return Member.UnitPrice.Value;
            }
        }

        public short UnitsInStock
        {
            get
            {
                return Member.UnitsInStock.Value;
            }
        }

        public short UnitsOnOrder
        {
            get
            {
                return Member.UnitsOnOrder.Value;
            }
        }
        public string Discontinued
        {
            get
            {
                if (Member.Discontinued == 1)
                    return "Discontinued";
                return "Not discontinued";
            }
        }
    }
}
