public class Program {
    static public int FindLargestNum(int[] arr) {
        int largestNum = 0;

        for (int index = 0; index < arr.Length; index++) {
            if (index == 0) {
                largestNum = arr[index];
            } else if (arr[index] > largestNum) {
                largestNum = arr[index];
            }
        }

        return largestNum;
    }
}