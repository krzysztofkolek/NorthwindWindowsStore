namespace NorthwindWindowsStore.ViewModel.VMTests
{
    using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

    [TestClass]
    public class SupplierVMTest : BaseTest<SupplierVM>
    {
        [TestMethod]
        [Timeout(10 * 60 * 1000)]
        public void CheckIfGridDataNotNull()
        {
            Assert.IsNotNull(TestObject.Grid, "Test checks it the data is different from null.");
        }
    }
}
