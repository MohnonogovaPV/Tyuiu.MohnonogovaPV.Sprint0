﻿namespace Tyuiu.MohnonogovaPV.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArray(int[] numOne, int[] numTwo)
        {
            int[] resultArray = new int[5];
            for (var i = 0; i < numOne.Length; i++)
            {
                resultArray[i] = numOne[i] + numTwo[i];
            }
            return resultArray;
        }
    }
}
