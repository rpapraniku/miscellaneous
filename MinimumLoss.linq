<Query Kind="Program" />

void Main()
{
	var prices = new List<int> { 20, 7, 8, 2, 5 };
	Console.WriteLine(MinimumLoss(prices));
}

public int MinimumLoss(List<int> prices)
{
	var dictionary = new Dictionary<int, int>();

	for (int i = 0; i < prices.Count; i++)
	{
		dictionary.Add(i, prices[i]);
	}

	var ordered = dictionary.OrderByDescending(x => x.Value);

	int minimumLoss = Int32.MaxValue;

	for (int i = 0; i < ordered.Count() - 1; i++)
	{
		if (ordered.ElementAt(i).Key > ordered.ElementAt(i + 1).Key)
		{
			continue;
		}

		int tempCalc = ordered.ElementAt(i).Value - ordered.ElementAt(i + 1).Value;
		Console.WriteLine($"[{ordered.ElementAt(i).Key}] {ordered.ElementAt(i).Value } - [{ordered.ElementAt(i + 1).Key}] {ordered.ElementAt(i + 1).Value } = {ordered.ElementAt(i).Value - ordered.ElementAt(i + 1).Value}");

		minimumLoss = Math.Min(tempCalc, minimumLoss);
	}

	return minimumLoss;
}
