using System;

using System.Collections.Generic;

using System.Text;

 

namespace Array

{

    class TwoSum

    {

        //Array of Number = [2,7,11,15] target = 9

        //Return [0,1]

 

        //Array of Number = [2,7,11,15,4,23,19,5] target = 19

        //Return [3,4]

 

 

        Dictionary<int,int> dict = new Dictionary<int, int>();

 

        public object TwoSumsProb(int[] arr, int target)

        {

            for(int i=0;i<arr.Length;i++)

            {

                if (dict.ContainsKey(arr[i]))

                {

                    int[] newArray = { dict[arr[i]], i };

                    string abc = "";

                    abc = newArray[0].ToString();

                    abc +=" , " + newArray[1].ToString();

                    return abc;

                }

                else

                    dict[target - arr[i]] = i;

            }

            return null;

        }

 

        static void Main(string[] args)

        {

            TwoSum twoSum = new TwoSum();

            int[] arr = { 2, 5, 7, 11, 15 };

            Console.WriteLine(twoSum.TwoSumsProb(arr, 9));

            Console.ReadLine();

        }

    }

}