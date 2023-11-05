using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KomarovMI.Sprint4.Task3.V10.Lib
{
    public class DataService : ISprint4Task3V10
    {
        public int Calculate(int[,] array)
        {

            int max = 0;
            for (int i=0; i <= array.Length - 1; i++)
                
            {
                if (i == 2)
                {
                    for(int j = 0; j <= array.Length - 1; j++)
                    {
                        if (array[i, j] > max)
                        {
                            max = array[i, j];
                        }
                    }
                }
            }
            return max;
        }
    }
}
