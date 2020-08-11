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

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr) {
        int higherHourglassSum = 0;
        int auxHourglassSum = 0;
        int[][] higherHourglass = new int[3][];
        
        //Percorre o array somente onde "encaixa" o hourglass
        for (int i = 0; i < 4; i++){
            for(int j = 0; j < 4; j++){

                //Armaneza a soma do hourglass em uma variavel auxiliar para ser comparada
                auxHourglassSum = arr[i][j] + arr[i][j+1] + arr[i][j+2] 
                    + arr[i+1][j+1] + arr[i+2][j] 
                    + arr[i+2][j+1] + arr[i+2][j+2];

                //Se for a primeira interação
                if(i == 0 && j == 0){
                    higherHourglassSum = auxHourglassSum;
                }else{
                    //Se a soma da variavel auxiliar for maior que o hourglass armazenado original
                    if(auxHourglassSum > higherHourglassSum){
                        higherHourglassSum = auxHourglassSum;
                    }
                }
            }
        }

        return higherHourglassSum;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
