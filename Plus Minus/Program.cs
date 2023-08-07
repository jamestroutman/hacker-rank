using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }

    }

    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            float positives = arr.Count(x => x > 0);
            float negatives = arr.Count(x => x < 0);
            float zeros = arr.Count(x => x == 0);
            float count = arr.Count();

            double positiveRate = positives / count;
            Console.WriteLine(positiveRate.ToString("0.000000"));

            double negativeRate = negatives / count;
            Console.WriteLine(negativeRate.ToString("0.000000"));

            double zeroRate = zeros / count;
            Console.WriteLine(zeroRate.ToString("0.000000"));
        }

    }
}