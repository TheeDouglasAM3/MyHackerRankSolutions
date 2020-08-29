using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    public static int BubbleSort(ref int[] arr){
        int numberOfSwaps = 0;
    
        for(int i = 0; i < arr.Length; i++) {
            for(int j = 0; j < arr.Length - 1; j++) {
                if(arr[j] > arr[j + 1]) {
                    int auxElement = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = auxElement;
                    numberOfSwaps++;
                }
            }

            if(numberOfSwaps == 0) {
                break;
            }
        }
        
        return numberOfSwaps;
    }

    public static void printDetailsAfterSort(int[] arr, int swaps){
        Console.WriteLine($"Array is sorted in {swaps} swaps.");
        Console.WriteLine($"First Element: {arr.First()}");
        Console.WriteLine($"Last Element: {arr.Last()}");
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        
        // Write Your Code Here
        int numberOfSwaps = BubbleSort(ref a);
        printDetailsAfterSort(a, numberOfSwaps);
    }
}