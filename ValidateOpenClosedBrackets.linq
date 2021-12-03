<Query Kind="Program" />

void Main()
{
	var brackets = new char[] { '{', '[', '[', ']', '(', ')', ']', '}' };
	Console.WriteLine(ValidateBalancedBracket(brackets));
}

public bool ValidateBalancedBracket(char[] list)
{
	var bracketStack = new List<char>();

	for (int i = 0; i < list.Length; i++)
	{
		bracketStack.Add(list[i]);
	}

	RunRecursive(bracketStack);

	return bracketStack.Count == 0;
}

public void RunRecursive(List<char> bracketStack)
{
	for (var i = 0; i < bracketStack.Count - 1; i++)
	{
		if (getOppsiteBracket(bracketStack.ElementAt(i)) == bracketStack.ElementAt(i + 1))
		{
			bracketStack.RemoveAt(i);
			bracketStack.RemoveAt(i);
			i--;
			i--;
		}
	}

	Console.WriteLine(bracketStack);
}

public char getOppsiteBracket(char n)
{
	switch (n)
	{
		case '[': n = ']'; break;
		case '{': n = '}'; break;
		case '(': n = ')'; break;
	}

	return n;
}

// Define other methods and classes here