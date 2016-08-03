namespace NorthwindWindowsStore.ViewModel.VMTests
{
    using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

    [TestClass]
    public class OrderVMTest : BaseTest<OrderVM>
    {
        [TestMethod]
        public void OrderVMTestCheckIfGridDataNotNull()
        {
            Assert.IsNotNull(TestObject.Grid, "Test checks it the data is different from null.");
        }

        [TestMethod]
        public void OrderVMTestCheckIfGridDataMoreThenZero()
        {
            Assert.IsTrue(TestObject.Grid.Count > 0, "Test checks it the data is more then zero.");
        }
    }
}
