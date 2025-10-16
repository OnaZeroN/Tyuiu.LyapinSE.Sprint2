using Tyuiu.LyapinSE.Sprint2.Task4.V2.Lib;

namespace Tyuiu.LyapinSE.Sprint2.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 9;
            double y = 4;

            Assert.AreEqual(11.5, ds.Calculate(x, y));
        }
    }
}
