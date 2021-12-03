<Query Kind="Program" />

void Main()
{
	string s = "143"
	Console.WriteLine(superDigit(s, 3));
}

public static int SumDigit(string str)
{
	return str.Select(s => int.Parse(s.ToString())).Sum();
}

public static int superDigit(string n, int k)
{
	int x = SumDigit(n);

	if (x < 10 && k != 1)
	{
		x = x * k;
		k = 1;
	}

	if (x < 10)
	{
		return x;
	}

	return superDigit(x.ToString(), k);
}