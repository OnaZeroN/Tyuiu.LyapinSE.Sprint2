using Tyuiu.LyapinSE.Sprint2.Task5.V15.Lib;

namespace Tyuiu.LyapinSE.Sprint2.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFindDayName()
        {
            var dataService = new DataService();

            string result1 = dataService.FindDayName(1);   
            string result2 = dataService.FindDayName(2);   
            string result3 = dataService.FindDayName(7);   
            string result4 = dataService.FindDayName(8);   
            string result5 = dataService.FindDayName(365); 

            Assert.AreEqual("Понедельник", result1);
            Assert.AreEqual("Вторник", result2);
            Assert.AreEqual("Воскресенье", result3);
            Assert.AreEqual("Понедельник", result4);
            Assert.AreEqual("Понедельник", result5);
        }
    }
}
