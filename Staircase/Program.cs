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
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        var spaces = n - 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= spaces; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= n- spaces; k++)
            {
                Console.Write("#");
            }

            Console.Write("\n");
            spaces--;
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
