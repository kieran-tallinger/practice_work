using System;
public class Program
{
	public static string smallerNum(string n1, string n2)
	{
     return Int32.Parse(n1) > Int32.Parse(n2) ? n2 : n1;
	}
}