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

class Solution
{

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr)
    {
        var n = arr.Length;

        int ans = 0;

        Dictionary<int, int> arrDict = new Dictionary<int, int>();

        for(int i=0;i<n-1;i++)
        {
            arrDict.Add(arr[i],i);
        }

        var sortedArrDict = arrDict.OrderBy(a => a.Value);

        bool[] vis = new bool[n];
        Array.Fill(vis, false);

        for (int i = 0; i < n-1; i++)
        {
            // already swapped and corrected or 
            // already present at correct pos 
            if (vis[i]==true || arrDict.GetValueOrDefault(i)==i)
                continue;

            // find out the number of  node in 
            // this cycle and add in ans 
            int cycle_size = 0;
            int j = i;
            while (!vis[j])
            {
                vis[j] = true;

                // move to next node 
                j = arrDict.GetValueOrDefault(j);
                cycle_size++;
            }

            // Update answer by adding current cycle. 
            if (cycle_size > 0)
            {
                ans += (cycle_size -1);
            }
        }

        // Return result 
        return ans+1;

    }

    static void Main(string[] args)
    {
        //TextWriter Console = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(System.Console.ReadLine());

        int[] arr = Array.ConvertAll(System.Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = minimumSwaps(arr);

        Console.WriteLine(res);

        Console.ReadLine();

        //Console.Close();
    }
}
