using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.LyapinSE.Sprint2.Task6.V9.Lib;

namespace Tyuiu.LyapinSE.Sprint2.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFindDateOfNextDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("16.3", ds.FindDateOfNextDay(3, 15));   
            Assert.AreEqual("1.3", ds.FindDateOfNextDay(2, 28));    
            Assert.AreEqual("1.5", ds.FindDateOfNextDay(4, 30));    
            Assert.AreEqual("31.12", ds.FindDateOfNextDay(12, 30)); 
        }
    }
}
