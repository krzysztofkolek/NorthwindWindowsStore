namespace NorthwindWindowsStore.ViewModel.VMTests
{
    using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

    [TestClass]
    public class EmployeeVMTest : BaseTest<EmployeeVM>
    {
        [TestMethod]
        public void EmployeeVMCheckIfGridDataNotNull()
        {
            Assert.IsNotNull(TestObject.Grid, "Test checks it the data is different from null.");
        }

        [TestMethod]
        public void EmployeeVMCheckIfGridDataMoreThenZero()
        {
            Assert.IsTrue(TestObject.Grid.Count > 0, "Test checks it the data is more then zero.");
        }
    }
}
