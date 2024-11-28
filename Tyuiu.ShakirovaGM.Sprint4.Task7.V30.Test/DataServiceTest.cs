using Tyuiu.ShakirovaGM.Sprint4.Task7.V30.Lib;
namespace Tyuiu.ShakirovaGM.Sprint4.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int rows = 5;
            int cols = 3;
            string str = "684259137159648";
            int[,] mas = new int[rows, cols] ;
            
            int res = ds.Calculate(rows,cols,str);
            int wait = 73728;
            Assert.AreEqual(wait, res);
        }
    }
}