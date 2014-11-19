using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQPCHwomeworkUsingVariablesDataConstants
{
    class TaskTwo
    {
        public void PrintStatistics(double[] arr, int count)
        {
            double max = 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            PrintMax(max);

            double min = 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            PrintMin(min);

            double sumOfAll = 0;
            for (int i = 0; i < count; i++)
            {
                sumOfAll += arr[i];
            }
            double average = sumOfAll / count;

            PrintAvg(average);
        }

        private void PrintAvg(double average)
        {
            Console.WriteLine(average);
        }
  
        private void PrintMin(double max)
        {
            Console.WriteLine(max);
        }

        private void PrintMax(double max)
        {
            Console.WriteLine(max);
        }
    }
}
