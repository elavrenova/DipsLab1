using DipsLab1.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDipsLab1
{
    [TestClass]
    public class TestGetString
    {
        [TestMethod]
        public void TestEmptyName()
        {
            var controller = new ValuesController();
            Assert.AreEqual(controller.GetString(2, null), "Somebody has 2 cats");
        }
    }
}
