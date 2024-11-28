using Tyuiu.ShakirovaGM.Sprint4.Task7.V30.Lib;
namespace Tyuiu.ShakirovaGM.Sprint4.Task7.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                DataService ds = new DataService();

                Console.Title = "Спринт #4 | Выполнил: Шакирова Г. М. | РППб-24-1";
                //Длинна строки 75 символов
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Спринт #4                                                               *");
                Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
                Console.WriteLine("* Задание #7                                                              *");
                Console.WriteLine("* Вариант #30                                                             *");
                Console.WriteLine("* Выполнил: Шакирова Гузель Мансуровна | РППб-24-1                        *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                *");
                Console.WriteLine("* Дана строка из одноразрядных цифр \"684259137159648\". Преобразуйте ее  *");
                Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение четных чисел.               *");


                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");

                int rows = 5;
                int cols = 3;
                string str = "684259137159648";
                int[,] mat = new int[rows, cols];

                Console.WriteLine("Массив");
                int index = 0;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"{str[index]}\t");
                        index++;
                    }
                    Console.WriteLine();
                }



                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");
                int res = ds.Calculate(rows, cols, str);
                Console.WriteLine("Произведение четных элементов строки = " + res);

                Console.ReadLine();
            }
        }
    }
}

