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

class Solution {

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {
        int count = 0;
        bool aboveSeaLevel = true;
        int steps = 0;
        foreach (char c in s)
        {
            if(c=='U')
            {
                steps++;
            }
            
            if(c=='D')
            {
                steps--;
            }

            if (steps < 0 && aboveSeaLevel == true)
            {
                count++;
                aboveSeaLevel = false;
            }
            else if (steps >= 0 && aboveSeaLevel == false)
            {
                aboveSeaLevel = true;
            }

        }

        return count;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
