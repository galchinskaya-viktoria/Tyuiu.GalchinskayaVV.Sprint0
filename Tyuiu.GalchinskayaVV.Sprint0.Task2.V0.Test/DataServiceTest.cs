using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalchinskayaVV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Вика";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Вика", res);
        }
    }
}
