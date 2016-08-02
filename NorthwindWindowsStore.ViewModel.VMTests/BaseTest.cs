namespace NorthwindWindowsStore.ViewModel.Test
{
    using NUnit.Framework;

    [TestFixture]
    public class BaseTest<T>
        where T : class, new()
    {
        protected T TestObject { get; set; }

        public BaseTest()
        {
            TestObject = new T();
        }

        [SetUp]
        public void Setup()
        {
            SetupAction();
        }

        [TearDown]
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
