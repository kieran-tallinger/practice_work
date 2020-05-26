public class Program {
    static public bool CheckEnding(string str1, string str2) {
        int check = 0;

        for (int index = 1; index <= str2.Length; index++) {
            if (str1[str1.Length - index] == str2[str2.Length - index]) {
                check++;
            } 
        }
        
        return check == str2.Length;
    }
}