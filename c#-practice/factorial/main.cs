public class Program {
    public static int Factorial(int num) {
		int count = num;

        for (int index = num - 1; index > 1; index--) {
            count = count * index;
        }

        return count;
    }
}