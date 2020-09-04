using System;
using System.Collections.Generic;
using System.IO;
class Solution {

    static void Main(String[] args) {
        int[] dateReturned = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] dateExpected = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int hackos = 0;
        if(dateReturned[2] > dateExpected[2])
            hackos = 10000;
        else if(dateReturned[1] > dateExpected[1] && dateReturned[2] == dateExpected[2])
            hackos = (dateReturned[1] - dateExpected[1]) * 500;
        else if(dateReturned[0] > dateExpected[0] && dateReturned[1] == dateExpected[1])
            hackos = (dateReturned[0] - dateExpected[0]) * 15;
        else
            hackos = 0;

        Console.WriteLine(hackos);
    }
}
