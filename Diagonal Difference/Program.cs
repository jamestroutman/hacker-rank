using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        return AbsoluteDiagonalDifference(arr);
    }

    public static int LeftToRightSum(List<List<int>> arr)
    {
        var sum = 0;

        for (var i = 0; i < arr.Count; i++)
        {
            sum += arr[i][i];
        }

        return sum;
    }

    public static int RightToLeftSum(List<List<int>> arr)
    {
        var sum = 0;
        var j = arr.Count;

        for (var i = 0; i < arr.Count; i++)
        {
            j--;
            sum += arr[i][j];
        }

        return sum;
    }

    public static int AbsoluteDiagonalDifference(List<List<int>> arr)
    {
        return Math.Abs(LeftToRightSum(arr) - RightToLeftSum(arr));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        //textWriter.WriteLine(result);

        Console.WriteLine(result);
        //textWriter.Flush();
        //textWriter.Close();
    }
}