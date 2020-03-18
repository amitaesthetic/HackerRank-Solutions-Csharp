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

    // Complete the minimumBribes function below.
    static string minimumBribes(int[] q)
    {
        int bribe = 0;
        //bool chaotic = false;
        int n = q.Length;
        for (int i = n-1; i >= 0; --i)
        {
            if (q[i] != i + 1)
            {
                if (i - 1 >= 0 && q[i-1] == i + 1)
                {
                    q[i - 1] = q[i];
                    q[i] = i + 1;
                    bribe++;
                }
                else if (i - 2 >= 0 && q[i-2] == i + 1)
                {
                    q[i - 2] = q[i - 1];
                    q[i - 1] = q[i];
                    q[i] = i + 1;
                    bribe+=2;
                }
                else
                {
                    return "Too chaotic";                    
                }
            }
        }
        
        return bribe.ToString();
    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        List<string> result = new List<string>();

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            
            result.Add(minimumBribes(q));
        }

        foreach(var abc  in result)
        {
            Console.WriteLine(abc);
        }

        Console.ReadLine();
    }
}
