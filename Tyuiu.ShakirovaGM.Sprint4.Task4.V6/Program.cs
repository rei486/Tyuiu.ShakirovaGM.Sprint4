using System.Data;
using Tyuiu.ShakirovaGM.Sprint4.Task4.V6.Lib;
namespace Tyuiu.ShakirovaGM.Sprint4.Task4.V6
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
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Шакирова Гузель Мансуровна | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 9.                          *");
            Console.WriteLine("* Заменить нечетные элементы массива на 0.                                *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] numsArray = new int[rows,cols];


            for (int i = 0; i <rows; i++)
            {
                for (int j = 0; j <cols; i++)
                {
                    Console.WriteLine($"Введите {i},{j} элемент массива:");
                    numsArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; i++)
                {
                    Console.Write($"{numsArray[i,j]}\t");

                }
                Console.WriteLine();
            }
            
            Console.WriteLine();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив с заменой нечетных элементов на 0: ");
            int[,] res = ds.Calculate(numsArray);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; i++)
                {
                    Console.Write($"{res[i, j]}\t");

                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
