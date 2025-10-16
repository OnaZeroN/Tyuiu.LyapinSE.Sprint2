using Tyuiu.LyapinSE.Sprint2.Task0.V2.Lib;

namespace Tyuiu.LyapinSE.Sprint2.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 123;
            int y = 123;

            bool[] expected = { false, true, false, true, false, true };

            bool[] result = ds.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}