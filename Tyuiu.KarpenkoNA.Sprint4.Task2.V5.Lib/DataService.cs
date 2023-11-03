﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KarpenkoNA.Sprint4.Task2.V5.Lib
{
    public class DataService : ISprint4Task2V5
    {
        public int Calculate(int[] array)
        {
            int multArray = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    multArray *= array[i];
                }
            }
            return multArray;
        }
    }
}
