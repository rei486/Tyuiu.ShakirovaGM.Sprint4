using Tyuiu.ShakirovaGM.Sprint4.Task6.V10.Lib;
namespace Tyuiu.ShakirovaGM.Sprint4.Task6.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Шакирова Г. М. | РППб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Шакирова Гузель Мансуровна | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Театр, Kино, Музей, Парк, Зоопарк, Концерт,*");
            Console.WriteLine("* Выставка], используя класс Array, выведите элементы массива, длина      *");
            Console.WriteLine("* которых меньше 7 символов.                                              *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

             string[] mas = { "Театр", "Кино", "Музей", "Парк", "Зоопарк", "Концерт", "Выставка" };

            Console.WriteLine("Исходный массив");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            foreach (var x in mas)
            {
                Console.WriteLine(x);
            }
                Console.ReadLine();
        }
    }
}
