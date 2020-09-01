public class Program {
    static public string Repeat(string word, int multiplier){
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        for (int index = 0; index < word.Length; index++) {
            sb.Append(word[index], multiplier);
        }
        return sb.ToString();
    }
}