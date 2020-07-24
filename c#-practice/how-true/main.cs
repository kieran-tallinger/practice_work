public class Program {
    static public int CountTrue(bool[] arr) {
        int count = 0;
        for (int index = arr.Length; index > 0; index--) {
            if (arr[index - 1] == true) count++;
        } 
        return count;
    }
}