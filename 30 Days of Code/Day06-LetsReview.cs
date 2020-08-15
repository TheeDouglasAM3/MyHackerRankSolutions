using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string numberTestCases = Console.ReadLine();

        for(int i = 0; i < Convert.ToInt32(numberTestCases); i++){
            string evenLettersInWord = "";
            string oddLetterInWord = "";
            string word = Console.ReadLine();

            for(int j = 0; j < word.Length; j++){
                if(j % 2 == 0) evenLettersInWord += word[j].ToString();
                else oddLetterInWord += word[j].ToString();
            }
            
            Console.WriteLine($"{evenLettersInWord} {oddLetterInWord}");
        }
    }
}