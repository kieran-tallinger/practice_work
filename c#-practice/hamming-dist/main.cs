public class Program {
    static public int HammingDistance(string str1, string str2) {
        int dist = 0;
        for (int index = 0; index < str1.Length; index++) {
            if (str1[index] != str2[index]) {
                dist = dist + 1;
            }
        }
        return dist;
    }
}