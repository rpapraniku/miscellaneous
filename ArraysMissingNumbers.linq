<Query Kind="Program" />

void Main()
{
	var brr = new int[] { 7, 2, 5, 4, 6, 3, 5, 3, 1 , 1 };

	var arr = new int[] { 7, 2, 5, 3, 5, 3 };

	Console.WriteLine(missingNumbers(arr, brr));

}

public int[] missingNumbers(int[] arr, int[] brr)
{
	var scanData = GetScanArray(brr);

	for (int i = 0; i < arr.Length; i++)
	{
		if (scanData.ContainsKey(arr[i])){
			scanData[arr[i]]--;
		}
	}
	
	Console.WriteLine(scanData);
	
	return scanData.Where(d => d.Value != 0).Select(x => x.Key).ToArray();
}

public Dictionary<int, int> GetScanArray(int[] arr)
{
	var scanArray = new Dictionary<int, int>();

	for (int i = 0; i < arr.Length; i++)
	{
		if (!scanArray.ContainsKey(arr[i]))
		{
			scanArray.Add(arr[i], 1);
			continue;
		}

		scanArray[arr[i]]++;
	}

	Console.WriteLine(scanArray);
	return scanArray;
}

// Define other methods and classes here