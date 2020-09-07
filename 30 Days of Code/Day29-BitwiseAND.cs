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
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int difference = 0;

            for(int a = 1; a <= n; a++){
                for(int b = 1; b <= n; b++){
                    int aAndBInt32 = Convert.ToInt32(a & b);
                    if(b > a && aAndBInt32 < k && aAndBInt32 > difference)
                        difference = aAndBInt32;
                }
            }

            Console.WriteLine(difference);
        }
    }
}
