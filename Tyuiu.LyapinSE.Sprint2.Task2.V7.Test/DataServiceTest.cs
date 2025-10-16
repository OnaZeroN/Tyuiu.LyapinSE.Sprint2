using Tyuiu.LyapinSE.Sprint2.Task2.V7.Lib;

namespace Tyuiu.LyapinSE.Sprint2.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 5;
            int y = 3;

            Assert.IsTrue(ds.CheckDotInShadedArea(x, y));

            x = 10;
            y = 12;

            Assert.IsFalse(ds.CheckDotInShadedArea(x, y));
        }
    }
}
