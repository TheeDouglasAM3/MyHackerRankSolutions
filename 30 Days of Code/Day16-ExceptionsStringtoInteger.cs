using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string S = Console.ReadLine();

        try {
            int stringConvertedToInt = Convert.ToInt32(S);
            Console.WriteLine(stringConvertedToInt);
        }catch{
            Console.WriteLine("Bad String");
        }
    }
}