public class Program {
    public static long CalculateExponent(long number, long exponent) 
    {
        long result = number;
        for (int index = 1; index < exponent; index++) {
            result = result * number;
        }
        return result;
    }
}