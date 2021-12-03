<Query Kind="Program" />

void Main()
{
	for (int i = 0; i < 20; i++)
	{
		fizzBuzz(i);
	}
	
}

public static void fizzBuzz(int n)
{
	if (n % 3 == 0 && n % 5 == 0)
	{
		Console.WriteLine(n + " " + "FinBuzz");
	}
	else if (n % 3 == 0)
	{
		Console.WriteLine(n + " " + "Fizz");
	}
	else if (n % 5 == 0)
	{
		Console.WriteLine(n + " " + "Buzz");
	}
	else
	{
		Console.WriteLine(n + " " + n.ToString());
	}
}