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

    // Complete the migratoryBirds function below.
    static int migratoryBirds(List<int> arr) {
        if(arr.Count == 1) return arr[0];
        arr.Sort();
        int typeBirdMostFrequentlySighted = arr[0];
        int timesBirdSpotted = 1;
        int maxTimesBirdSpotted = 0;
        for(int i = 1; i < arr.Count; i++){
            if(arr[i] == arr[i - 1]){
                timesBirdSpotted += 1;
                if(timesBirdSpotted > maxTimesBirdSpotted){
                    maxTimesBirdSpotted = timesBirdSpotted;
                    typeBirdMostFrequentlySighted = arr[i];
                }
            }else{
                timesBirdSpotted = 1;
            }
        }

        return typeBirdMostFrequentlySighted;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
