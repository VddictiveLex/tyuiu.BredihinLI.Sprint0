using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using tyuiu.BredihinLI.Sprint0.Task2.V0.Lib;
namespace tyuiu.BredihinLI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Лев";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Лев", res);
        }
    }
}
