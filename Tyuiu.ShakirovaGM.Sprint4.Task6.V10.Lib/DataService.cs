using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShakirovaGM.Sprint4.Task6.V10.Lib
{
    public class DataService : ISprint4Task6V10
    {
        public string[] Calculate(string[] mass)
        {
            string[] res = Array.FindAll(mass, x=>x.Length<7);
            return res;
        }
    }
}
