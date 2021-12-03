<Query Kind="Program" />

void Main()
{
	var arr = new List<int>() { 6, 3, 5, 1, 3, 2, 0, 13 };
	Console.WriteLine(SortArray(arr));

}

public int[] SortArray(List<int> arr)
{

	var array = arr.ToArray();
	var freq = new int[array.Max() + 1];

	for (int i = 0; i < array.Length; i++)
	{
		freq[array[i]]++;
	}

	var newArray = new int[arr.Capacity];

	int n = 0;
	for (int i = 0; i < freq.Length; i++)
	{
		int t = i;
		if (freq[t] > 0)
		{
			for (int k = i; k < i + freq[t]; k++)
			{
				newArray[n] = i;
				n++;
			}
		}
	}

	return newArray;

}

// Define other methods and classes here
