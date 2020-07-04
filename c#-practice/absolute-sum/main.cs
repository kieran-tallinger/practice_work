public class Program {
    public static int GetAbsSum(int[] arr) {
      int count = 0;

      for (int index = 0; index < arr.Length; index++) {
				if (arr[index] < 0) {
					count = count - arr[index];
				} else if (arr[index] >= 0) {
					count = count + arr[index];
				}    
      }
      return count;
    }
}
