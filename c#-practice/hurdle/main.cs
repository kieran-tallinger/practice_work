public class Program {
    static public bool hurdleJump(int[] arr, int jump) {
        for (int index = 0; index < arr.Length; index++) {
            if (arr[index] > jump) {
                return false;
            }
        }

        return true;
    }
}