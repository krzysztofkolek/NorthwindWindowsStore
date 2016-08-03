namespace NorthwindWindowsStore.ViewModel.VMTests
{
    using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

    [TestClass]
    public class ProductVMTest : BaseTest<ProductVM>
    {
        [TestMethod]
        public void ProductVMTestCheckIfGridDataNotNull()
        {
            Assert.IsNotNull(TestObject.Grid, "Test checks it the data is different from null.");
        }

        [TestMethod]
        public void ProductVMTestCheckIfGridDataMoreThenZero()
        {
            Assert.IsTrue(TestObject.Grid.Count > 0, "Test checks it the data is more then zero.");
        }
    }
}
