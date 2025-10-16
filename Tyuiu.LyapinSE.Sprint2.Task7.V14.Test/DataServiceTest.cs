using Tyuiu.LyapinSE.Sprint2.Task7.V14.Lib;

namespace Tyuiu.LyapinSE.Sprint2.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(0.1, 0));
            Assert.IsTrue(ds.CheckDotInShadedArea(0, 0));
            Assert.IsTrue(ds.CheckDotInShadedArea(0, -0.1));
            Assert.IsFalse(ds.CheckDotInShadedArea(-0.1, 0));
            Assert.IsFalse(ds.CheckDotInShadedArea(-0.1, -0.1));
        }
    }
}
