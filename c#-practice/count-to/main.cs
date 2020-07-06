public class Program {
    static public int AddUp(int num) {
        int total = 0;

        for (int index = 0; index <= num; index++) {
            total += index;
        }

        return total;
    }
}