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

namespace SockMerchant
{
    class Program
    {
        static int sockMerchant(int n, int[] ar) {
            var list = ar.ToList();
            list.Sort();
            Console.WriteLine(string.Join(" ", list));

            var matchCount = 0;

            for(int i=0; i < n-1; i++)
            {
                if(list[i] == list[i + 1])
                {
                    matchCount++;
                    i++;
                }
            }

            return matchCount;
        }

        static void Main(string[] args)
        {
            int[] ar = Array.ConvertAll("10 20 20 10 10 50 50 10 20 70 90 20".Split(' '), arTemp => Convert.ToInt32(arTemp));
            int n = ar.Count();

            int result = sockMerchant(n, ar);

            Console.WriteLine(result);

        }
    }
}
