<Query Kind="Program" />

void Main()
{
	var s1 = "abcde";
	var s2 = "edcb";

	Console.WriteLine(CalculateAnagram(s1, s2));
}

public int CalculateAnagram(string s1, string s2)
{
	var freqDict = new Dictionary<char, int>();

	foreach (var element in s1.ToCharArray())
	{
		if (freqDict.ContainsKey(element))
		{
			freqDict[element]++;
			continue;
		}
		freqDict.Add(element, 1);
	}

	foreach (var element in s2.ToCharArray())
	{
		if (freqDict.ContainsKey(element))
		{
			freqDict[element]--;
			continue;
		}

		freqDict.Add(element, -1);
	}

	Console.WriteLine(freqDict);

	return freqDict.Values.Where(v => v != 0).Select(x => Math.Abs(x)).Sum();
}

// Define other methods and classes here
