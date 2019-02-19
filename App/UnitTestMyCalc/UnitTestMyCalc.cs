using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcLib;
//Simple example for Harvard students on course Computer Science
namespace UnitTestMyCalc
{
    [TestClass]
    public class UnitTestMyCalc
    {
        [TestMethod]
        public void TestAdd_20_30_50()
        {
            //set
            int x = 20;
            int y = 30;
            int expected = 50;
            //act
            MyCalc c = new MyCalc();
            int actual = c.Sum(x, y);
            //asset
            Assert.AreEqual(expected, actual);
        }
    }
}
