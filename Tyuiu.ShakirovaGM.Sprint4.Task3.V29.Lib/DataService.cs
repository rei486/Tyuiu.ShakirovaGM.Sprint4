﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShakirovaGM.Sprint4.Task3.V29.Lib
{
    public class DataService : ISprint4Task3V29
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int cols = array.Length/ rows;
            int p = 1;
            for (int i = 0; i <rows; i++)
            {
                for (int j = 0; j <cols; j++)
                {
                    if (j == 0)
                    {


                        p *= array[i, j];
                    }
                }
            }
            return p;
        }
    }
}
