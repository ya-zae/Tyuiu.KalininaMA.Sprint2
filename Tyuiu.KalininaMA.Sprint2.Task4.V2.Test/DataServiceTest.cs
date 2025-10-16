using Tyuiu.KalininaMA.Sprint2.Task4.V2.Lib;

namespace Tyuiu.KalininaMA.Sprint2.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 21;
            Assert.AreEqual(res, wait);
        }
    }
}
