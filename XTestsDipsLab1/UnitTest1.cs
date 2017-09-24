using DipsLab1.Controllers;
using System;
using Xunit;

namespace XTestsDipsLab1
{
    public class UnitTest1
    {

        [Fact]
        public void TestZeroValueEmptyName()
        {
            var controller = new ValuesController();
            Assert.Equal(controller.GetString(0, null), "Somebody doesn't have any cats");
        }

        [Fact]
        public void TestValueEmptyName()
        {
            var controller = new ValuesController();
            Assert.Equal(controller.GetString(2, null), "Somebody has 2 cats");
        }

        [Fact]
        public void TestZeroValueName()
        {
            var controller = new ValuesController();
            Assert.Equal(controller.GetString(0, "Maria"), "Maria doesn't have any cats");
        }

        [Fact]
        public void TestValueName()
        {
            var controller = new ValuesController();
            Assert.Equal(controller.GetString(3, "Peter"), "Peter has 3 cats");
        }
    }
}
