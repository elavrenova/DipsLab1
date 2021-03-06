using DipsLab1.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDipsLab1
{
    [TestClass]
    public class TestGetString
    {
        [TestMethod]
        public void TestZeroValueEmptyName()
        {
            var controller = new ValuesController();
            Assert.AreEqual(controller.GetString(0, null), "Somebody doesn't have any cats");
        }

        [TestMethod]
        public void TestValueEmptyName()
        {
            var controller = new ValuesController();
            Assert.AreEqual(controller.GetString(2, null), "Somebody has 2 cats");
        }

        [TestMethod]
        public void TestZeroValueName()
        {
            var controller = new ValuesController();
            Assert.AreEqual(controller.GetString(0, "Maria"), "Maria doesn't have any cats");
        }

        [TestMethod]
        public void TestValueName()
        {
            var controller = new ValuesController();
            Assert.AreEqual(controller.GetString(3, "Peter"), "Peter has 3 cats");
        }

        [TestMethod]
        public void TestName()
        {

        }

    }
}
