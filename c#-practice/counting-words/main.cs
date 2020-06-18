public class Program {
        public static int CountWords(string str) {
            int count = 1;

            for (int index = 0; index < str.Length; index++) {
                if (str[index] == ' ') {
                    count++;
                }
            }
            
            return count;
        }
    }