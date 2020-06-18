public class Program {
    public static int CharCount(char myChar, string str) {
        int count = 0;

        for (int index = 0; index < str.Length; index++) {
            if (str[index] == myChar) {
                count++;
            }
        }

        return count;
    }
}
