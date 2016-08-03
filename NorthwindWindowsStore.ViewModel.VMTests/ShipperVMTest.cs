namespace NorthwindWindowsStore.ViewModel.VMTests
{
    using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

    [TestClass]
    public class ShipperVMTest : BaseTest<ShipperVM>
    {
        [TestMethod]
        public void ShipperVMTestCheckIfGridDataNotNull()
        {
            Assert.IsNotNull(TestObject.Grid, "Test checks it the data is different from null.");
        }

        [TestMethod]
        public void ShipperVMTestCheckIfGridDataMoreThenZero()
        {
            Assert.IsTrue(TestObject.Grid.Count > 0, "Test checks it the data is more then zero.");
        }
    }
}
