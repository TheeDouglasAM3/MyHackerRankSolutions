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

    static void Main(string[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        var firstNames = new List<string>();

        for (int NItr = 0; NItr < N; NItr++) {
            string[] firstNameEmailID = Console.ReadLine().Split(' ');

            string firstName = firstNameEmailID[0];

            string emailID = firstNameEmailID[1];

            if(Regex.IsMatch(emailID, @"\b(@gmail.com)\b"))
                firstNames.Add(firstName);                
        }

        firstNames.Sort();
        foreach(string name in firstNames)
            Console.WriteLine(name);

    }
}
