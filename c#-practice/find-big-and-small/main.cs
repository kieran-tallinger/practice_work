using System;
using System.Linq;
public class Program 
{
    public static double[] FindMinMax(double[] values) 
    {
        double[] MinMax = new double[] {values.Min(), values.Max()};
        return MinMax;
    }
}