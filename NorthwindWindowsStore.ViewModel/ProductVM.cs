
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
    }
}
