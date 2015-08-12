using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParamsOutExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int min;
            int max;
            int cnt;
            int sum;
            double avg;

            processArray(out min
                       , out max
                       , out cnt
                       , out sum
                       , out avg
                       , 5, 2, 9, 23, 15, 28, 7, 11);


            Console.WriteLine("Min: {0}\nMax: {1}\nCnt: {2}\nSum: {3}\nAvg: {4:n6}\n"
                              , min, max, cnt, sum, avg);

        }

        private static void processArray(out int min
                                       , out int max
                                       , out int cnt
                                       , out int sum
                                       , out double avg
                                       , params int[] input)
        {
            sum = 0;

            foreach (int element in input)
            {
                sum += element;
            }

            cnt = input.Length;
            avg = sum / (double)input.Length;
            Array.Sort(input);
            min = input[0];
            max = input[input.Length - 1];
        }
    }
}
