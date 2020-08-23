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

    static List<int> _findIndexesWhereIncludeAInString(string s) {
        var listIncludeA = new List<int>();
        for(int i = 0; i < s.Length; i++) {
            if(s[i] == 'a') {
                listIncludeA.Add(i);
            }
        }
        return listIncludeA;
    }

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n) {
        var indexesWhereIncludeA = _findIndexesWhereIncludeAInString(s);
        long loopsInString = n / s.Length;
        long modLoopsInString = n % s.Length;
        long repeatedA = indexesWhereIncludeA.Count * loopsInString;
        
        for(int i = 0; i < modLoopsInString; i++) {
            if(s[i] == 'a')
                repeatedA += 1;
        }
        return repeatedA;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
