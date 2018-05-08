using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Singleton.Tests
{
    [TestClass]
    public class Singleton_Tests
    {
        [TestMethod]
        public void IsPolicyASingleton()
        {
            Assert.AreSame(Policy.Instance, Policy.Instance);
        }
    }
}
