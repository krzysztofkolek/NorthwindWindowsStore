
namespace NorthwindWindowsStore.ViewModel.VMTests
{
    using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

    [TestClass]
    public abstract class BaseTest<T>
        where T : class, new()
    {
        protected T TestObject { get; set; }

        public BaseTest()
        {
            TestObject = new T();
        }

        [ClassInitialize]
        public void Setup()
        {
            SetupAction();
        }

        [ClassCleanup]
        public void TearDown()
        {
            TearDownAction();
        }

        public virtual void SetupAction()
        { }

        public virtual void TearDownAction()
        { }
    }
}
