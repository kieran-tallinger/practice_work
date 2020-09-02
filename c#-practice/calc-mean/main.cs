using System;
public class Program {
    static public double Mean(int[] arr) {
        double mean = 0;
        for (int index = 0; index < arr.Length;index++) {
            mean = mean + arr[index];
        }
        mean = mean / arr.Length;
        return Math.Round(mean,2);
    }
}