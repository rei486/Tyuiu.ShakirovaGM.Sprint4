using Tyuiu.ShakirovaGM.Sprint4.Task5.V10.Lib;
namespace Tyuiu.ShakirovaGM.Sprint4.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5] { { 1, 1, 0, 1, -1 },
                                        { 2, 1, 0, -1, -1 },
                                        { 2, 1, 0, -2, -1 },
                                        { 2, 1, 0, -1, -4},
                                        { 2, 1, 0, -3, -4 } };
            int res = ds.Calculate(mas);
            int wait = 15;
            Assert.AreEqual(wait, res);
        }
    }
}