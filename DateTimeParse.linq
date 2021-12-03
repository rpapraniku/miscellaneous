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

void Main()
{
}

class Result
{

	/*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

	public static string timeConversion(string s)
	{
		return DateTime.Parse(s).ToString("HH:mm:ss");
	}
}

public static void Main(string[] args)
{
	string s = "07:05:45PM";
	Console.WriteLine(Result.timeConversion(s));
}

