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
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

	public static long flippingBits(long n)
	{
		string binary = Convert.ToString(n, 2).PadLeft(32, '0');
		string flipped = "";

		foreach (char charElem in binary.ToCharArray())
		{
			if (charElem == '0')
			{
				flipped += "1";
				continue;
			}
			flipped += "0";
		}

		return Convert.ToUInt32(flipped, 2);
	}

}

public static void Main(string[] args)
{
	var list = new List<long> { 2147483647, 1, 0 };

	foreach (var item in list)
	{
		long n = Convert.ToInt64(item);

		long result = Result.flippingBits(n);

		Console.WriteLine(result);

	}
}
