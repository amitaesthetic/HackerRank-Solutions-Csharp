using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        List<int> seq;
        var userInput = Console.ReadLine();
        var userInputSplits = userInput.Split(' ');
        var numberOfSequences = int.Parse(userInputSplits[0]);
        var numberOfQueries = int.Parse(userInputSplits[1]);
        var seqList = new List<List<int>>(new List<int>[numberOfSequences]);
        var lastAns = 0;
        for (var i = 0; i < numberOfQueries; i++)
        {
            userInput = Console.ReadLine();
            userInputSplits = userInput.Split(' ');
            var queryType = int.Parse(userInputSplits[0]);
            var x = int.Parse(userInputSplits[1]);
            var y = int.Parse(userInputSplits[2]);
            var seqIndex = (x ^ lastAns) % numberOfSequences;
            switch (queryType)
            {
                case 1:
                    if (seqList[seqIndex] != null)
                        seqList[seqIndex].Add(y);
                    else
                    {
                        seq = new List<int>();
                        seq.Add(y);
                        seqList[seqIndex] = seq;
                    }
                    break;
                case 2:
                    seq = seqList[seqIndex];
                    lastAns = seq[y % seq.Count];
                    Console.WriteLine(lastAns);
                    break;
            }
        }
    }
}
