using Tyuiu.ShakirovaGM.Sprint4.Task2.V6.Lib;
namespace Tyuiu.ShakirovaGM.Sprint4.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 1,2,3,4,5,6,7,8,9,10};
            int res = ds.Calculate(numsArray);
            int wait = 945;
            Assert.AreEqual(res, wait);
        }
    }
}