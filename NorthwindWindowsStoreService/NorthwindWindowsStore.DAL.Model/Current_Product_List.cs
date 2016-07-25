namespace NorthwindWindowsStore.DAL.Model
{
    using NorthwindWindowsStore.DAL.Model.Interface;

    public partial class Current_Product_List : ICurrentProductList, IView
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
    }
}
