using Tyuiu.LyapinSE.Sprint2.Task3.V8.Lib;

namespace Tyuiu.LyapinSE.Sprint2.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            double x = 5;

            Assert.AreEqual(-0.543, ds.Calculate(x));
        }
    }
}
