using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorodulinMS.SprintReview1.TaskReview.V27.Lib;

namespace Tyuiu.BorodulinMS.SprintReview1.TaskReview.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-3.597, res);
        }
    }
}
