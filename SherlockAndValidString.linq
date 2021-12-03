<Query Kind="Program" />

void Main()
{
	string s = "AABBCCA";

	Console.WriteLine(SherlockAndValidString(s));
}

public bool SherlockAndValidString(string s)
{

	var freq = new Dictionary<char, int>();

	foreach (var charachter in s.ToCharArray())
	{
		if (!freq.ContainsKey(charachter))
		{
			freq.Add(charachter, 0);
			continue;
		}

		freq[charachter]++;
	}
	var sortedArray = freq.Values.ToArray();
	Array.Sort(sortedArray);

	var first = sortedArray[0];
	var second = sortedArray[1];
	var lastSecond = sortedArray[sortedArray.Length - 2];
	var last = sortedArray[sortedArray.Length - 1];

	if (first == last)
	{
		return true;
	}

	if (first == 1 && second == last)
	{
		return true;
	}

	if (first == second && second == lastSecond && lastSecond == (last - 1))
	{
		return true;
	}

	return false;
}

// Define other methods and classes here
