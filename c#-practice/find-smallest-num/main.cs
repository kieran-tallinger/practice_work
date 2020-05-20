public class Program {
    public static double FindSmallestNum(double[] arr) {
        double temp;
        for (int firstIndex = 0; firstIndex < arr.Length; firstIndex++) {
            for (int secondIndex = firstIndex + 1; secondIndex < arr.Length; secondIndex++) {
                if (arr[firstIndex] > arr[secondIndex]) {
                    temp = arr[firstIndex];
                    arr[firstIndex] = arr[secondIndex];
                    arr[secondIndex] = temp;
                }
            }
        }
        return arr[0];
    }
}