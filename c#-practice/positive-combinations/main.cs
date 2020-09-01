public class Program {
	public static int PosCom(int n) {
		int baseNum = 2;
        int result = 2;
        for (int index = 1; index < n; index++){
            result = result * baseNum;
        }
        return result;
	}
}