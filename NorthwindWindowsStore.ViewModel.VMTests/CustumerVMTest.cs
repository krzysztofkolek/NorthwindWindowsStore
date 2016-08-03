namespace NorthwindWindowsStore.ViewModel.VMTests
{
    using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

    public class CustumerVMTest : BaseTest<CustumerVM>
    {
        [TestMethod]
        public void CustumerVMTestCheckIfGridDataNotNull()
        {
            Assert.IsNotNull(TestObject.Grid, "Test checks it the data is different from null.");
        }

        [TestMethod]
        public void CustumerVMTestCheckIfGridDataMoreThenZero()
        {
            Assert.IsTrue(TestObject.Grid.Count > 0, "Test checks it the data is more then zero.");
        }
    }
}
