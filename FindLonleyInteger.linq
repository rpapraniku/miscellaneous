<Query Kind="Program">
  <Namespace>System</Namespace>
  <Namespace>System.CodeDom.Compiler</Namespace>
  <Namespace>System.Collections</Namespace>
  <Namespace>System.Collections.Generic</Namespace>
  <Namespace>System.ComponentModel</Namespace>
  <Namespace>System.Diagnostics.CodeAnalysis</Namespace>
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.IO</Namespace>
  <Namespace>System.Linq</Namespace>
  <Namespace>System.Reflection</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Text</Namespace>
  <Namespace>System.Text.RegularExpressions</Namespace>
</Query>


class Result
{

	/*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

	public static int lonelyinteger(List<int> a)
	{
		var freq = new Dictionary<int, int>();

		for (int i = 0; i < a.Count ; i++)
		{
			if (!freq.ContainsKey(a[i]))
			{
				freq.Add(a[i], 1);
				continue;
			}

			freq[a[i]]++;
		}

		return freq.FirstOrDefault(x => x.Value == 1).Key;
	}

}

public static void Main(string[] args)
{
	Console.WriteLine(Result.lonelyinteger(new List<int>() { 1, 2, 4, 5, 2, 1, 4 }));
}
