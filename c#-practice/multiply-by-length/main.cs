public class Program {
    static public int[] MultiplyByLength(int[] arr) {
        int count = 0;
        int[] newArr = new int[arr.Length];
        foreach(int i in arr) {
            newArr[count] = arr[count] * arr.Length;
            count++;
        } 
        return newArr;
    }
}