using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

	// Add your code here
    public Difference(int[] elements){
        this.elements = elements;
    }

    int count = 0;
    int difference = 0;
    public void computeDifference(){
        for(int i = 0; i < elements.Length; i++){
            while(count + 1 < elements.Length){
                difference = Math.Abs(elements[i] - elements[count + 1]);
                if(difference > maximumDifference)
                    maximumDifference = difference;
                count++;
            }
            count = i + 1;
        }
    }

} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}