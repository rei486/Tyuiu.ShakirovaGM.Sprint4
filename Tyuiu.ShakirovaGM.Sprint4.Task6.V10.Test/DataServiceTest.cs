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
            string[] mas ={ "�����", "����", "�����", "����", "�������", "�������", "��������" };
            string[]res = ds.Calculate(mas);
            string[] wait = { "�����", "����", "�����", "����"};
            Assert.AreEqual(res, wait);
        }
    }
}