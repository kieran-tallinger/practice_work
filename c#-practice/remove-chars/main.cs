public class Program {
    static public string RemoveFirstLast(string str) {
        if (str.Length > 2){
			str = str.Remove(0,1);
            str = str.Remove(str.Length - 1, 1);
            return str;	
		    }
	    return str;
    }
}