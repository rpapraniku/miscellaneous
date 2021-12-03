<Query Kind="Program" />

void Main()
{
	var s1 = "barbell";
	var s2 = "tarpper";

	Console.WriteLine(IntersectionWithSubStrings(s1, s2));
}

public List<char> IntersectionWithSubStrings(string s1, string s2)
{
	var s1h = new HashSet<char>();
	var s2h = new HashSet<char>();

	foreach (var element in s1.ToCharArray())
	{
		s1h.Add(element);
	}

	foreach (var element in s2.ToCharArray())
	{
		s2h.Add(element);
	}

	var common = s1h.Intersect(s2h).ToList();

	if (common.Count > 0)
	{
		return common;
	}
	
	return null;
}

// Define other methods and classes here
