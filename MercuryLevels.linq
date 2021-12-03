<Query Kind="Program">
  <Namespace>System</Namespace>
</Query>

void Main()
{
	var data = ReadFile().ToList();

	int mainValue = int.Parse(data.ElementAt(0));

	for (var e = 1; e <= mainValue; e++)
	{
		var splitData = Regex.Split(data[e], "\t").ToList();
		if (!double.TryParse(splitData[1], out double value))
		{
			var res = data.ExtraxtValue(e, 2);
			Console.WriteLine(res);
		}
	}
}

public static class Util
{
	public static double ExtraxtValue(this List<string> sourceList, int currentIndex, int n)
	{
		var result = new List<double>();

		foreach (var element in sourceList.GetRange(currentIndex - n, n))
		{
			var extractedValue = Regex.Split(element, "\t")[1];

			if (double.TryParse(extractedValue, out double value))
			{
				result.Add(value);
			}
		}

		return result.Sum() / n;
	}
}

public string[] ReadFile()
{
	System.IO.StreamReader reader = new StreamReader("C:\\Users\\rpapraniku\\OneDrive - ENDAVA\\Desktop\\input000_1.txt");
	var stringData = reader.ReadToEnd();
	var data = stringData.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
	return data;
}

// Define other methods and classes here