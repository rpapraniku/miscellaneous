<Query Kind="Program" />

void Main()
{
	var sampleArr = new int[] { 1, 2, 3, 4, 5, 6, 7 };

	RotateLeft(sampleArr, 3);

	Console.WriteLine(sampleArr);
}


public void RotateLeft(int[] arr, int k)
{
	k %= arr.Length;
	int[] temp = new int[k];
	
	for (int i = 0; i < k; i++)
	{
		temp[i] = arr[i];
	}
	
	for (int i = 0; i < arr.Length - k; i++)
	{
		arr[i] = arr[i + k];
	}
	
	for (int i = arr.Length - k; i < arr.Length; i++)
	{
		arr[i] = temp[i - k - 1];
	}
}
// Define other methods and classes here
