using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        
        //Declare variables and read inputs
        int i2 = Convert.ToInt32(Console.ReadLine());
        double d2 = Convert.ToDouble(Console.ReadLine());
        string s2 = Console.ReadLine();
        
        //Sum integers and doubles, concatanete strings
        i2 += i;
        d2 += d;
        s2 = s + s2;

        // Print the results.
        textWriter.WriteLine(i2);
        textWriter.WriteLine(String.Format("{0:0.0}", d2));
        textWriter.WriteLine(s2);

        textWriter.Flush();
        textWriter.Close();
    }
}