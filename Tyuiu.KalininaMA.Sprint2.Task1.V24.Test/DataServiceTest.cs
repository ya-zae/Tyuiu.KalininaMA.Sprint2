using Tyuiu.KalininaMA.Sprint2.Task1.V24.Lib;

namespace Tyuiu.KalininaMA.Sprint2.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 325, b = 325, c = 242, d = 324;
            bool[] result = ds.GetLogicOperations(a, b, c, d);
            bool[] expected = { true, false, true, false, true, false };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
