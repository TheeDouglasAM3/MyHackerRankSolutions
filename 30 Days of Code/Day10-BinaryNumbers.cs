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

    static bool isTheFirstOneThatAppeared (int countOfConsecutiveOnes, char current){
        return countOfConsecutiveOnes == 0 && current == '1';
    }

    static bool areConsecutiveOfOnes (char current, char prev){
        return current == '1' && prev == '1';
    }

    static void Main(string[] args) {
        int numberOfConsecutiveOnes = 0;
        int auxCount = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        string binaryNumber = Convert.ToString(n, 2);

        for(int i = 0; i < binaryNumber.Length; i++){

            if(
                isTheFirstOneThatAppeared(auxCount, binaryNumber[i])
                || areConsecutiveOfOnes(binaryNumber[i], binaryNumber[i - 1])
            ){
                auxCount += 1;
            }

            if(auxCount > numberOfConsecutiveOnes)
                numberOfConsecutiveOnes = auxCount;
            
            if(binaryNumber[i] == '0')  
                auxCount = 0;
        }

        Console.WriteLine(numberOfConsecutiveOnes);
    }
}
