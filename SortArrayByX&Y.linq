<Query Kind="Program" />

void Main()
{
	int[,] arr = new int[4, 4];
	arr[0, 0] = 112;
	arr[0, 1] = 42;
	arr[0, 2] = 83;
	arr[0, 3] = 119;
	arr[1, 0] = 56;
	arr[1, 1] = 125;
	arr[1, 2] = 56;
	arr[1, 3] = 49;
	arr[2, 0] = 15;
	arr[2, 1] = 78;
	arr[2, 2] = 101;
	arr[2, 3] = 43;
	arr[3, 0] = 62;
	arr[3, 1] = 98;
	arr[3, 2] = 114;
	arr[3, 3] = 108;

	Console.WriteLine(arr);
	//PrintEveryRowAndColumn(arr);
	Console.WriteLine(getMaxNumberOnTopLeft(arr));
}

public void PrintEveryRowAndColumn(int[,] arr)
{
	for (int r = 0; r < arr.GetLength(0); r++)
	{
		for (int i = 0; i < arr.GetLength(0); i++)
		{
			Console.Write(arr[r, i] + " ");
		}
		Console.WriteLine(" ");
	}
}

public int getMaxNumberOnTopLeft(int[,] arr)
{
	for (int r = 0; r < arr.GetLength(0); r++)
		for (int k = 0; k < arr.GetLength(1) - 1; k++)
			if (arr[r, k] < arr[r, k + 1])
			{
				var temp = arr[r, k];
				arr[r, k] = arr[r, k + 1];
				arr[r, k + 1] = temp;
				Console.WriteLine($"{arr[r, k]} , {arr[r, k + 1]}");
				k = -1;
			}

	for (int c = 0; c < arr.GetLength(0); c++)
		for (int k = 0; k < arr.GetLength(1) - 1; k++)
			if (arr[k, c] < arr[k + 1, c])
			{
				var temp = arr[k, c];
				arr[k, c] = arr[k + 1, c];
				arr[k + 1, c] = temp;
				Console.WriteLine($"{arr[k, c]} , {arr[k + 1, c]}");
				k = -1;
			}

	Console.WriteLine(arr);

	return arr[0, 0];
}

// Define other methods and classes here
