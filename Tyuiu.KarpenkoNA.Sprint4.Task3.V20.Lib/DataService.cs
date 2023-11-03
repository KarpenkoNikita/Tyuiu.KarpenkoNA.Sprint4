using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KarpenkoNA.Sprint4.Task3.V20.Lib
{
    public class DataService : ISprint4Task3V20
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int count = int.MaxValue;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, 1] < count)
                    {
                        count = array[i, 1]; 
                    }
                }
            }
            return count;
        }
    }
}
