using Tyuiu.ShakirovaGM.Sprint4.Task6.V10.Lib;
namespace Tyuiu.ShakirovaGM.Sprint4.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] mas ={ "Театр", "Кино", "Музей", "Парк", "Зоопарк", "Концерт", "Выставка" };
            string[]res = ds.Calculate(mas);
            string[] wait = { "Театр", "Кино", "Музей", "Парк"};
            Assert.AreEqual(res, wait);
        }
    }
}