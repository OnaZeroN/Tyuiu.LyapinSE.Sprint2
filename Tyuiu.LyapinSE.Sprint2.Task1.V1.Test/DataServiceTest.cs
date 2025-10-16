using Tyuiu.LyapinSE.Sprint2.Task1.V1.Lib;

namespace Tyuiu.LyapinSE.Sprint2.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 119;
            int b = 196;
            int c = 134;
            int d = 327;

            bool[] expected = { true, false, true, false, true, false };

            bool[] result = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
