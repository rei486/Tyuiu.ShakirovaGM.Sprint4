﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShakirovaGM.Sprint4.Task1.V2.Lib
{
    public class DataService : ISprint4Task1V2
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            for (int i = 1; i <=7; i++)
            {
                if (array[i] % 2 != 0)
                    sum += array[i];
            }
            return sum;
        }
    }
}