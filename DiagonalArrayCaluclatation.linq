<Query Kind="Program" />

void Main()
{
	var list = new List<List<int>>{
		new List<int>{11,2, 4},
		new List<int>{4 ,5, 6},
		new List<int>{10, 8, -12}
	};
	int[][] arr = ConvertTo2Darray(list);
	Console.WriteLine(ConvertTo2Darray(list));

	Console.WriteLine(SumDiagonal(arr));
}

int SumDiagonal(int[][] arr)
{
	int sum = 0;
	int sum1 = 0;
	int i = 0;
	int j = 0;
	var xLength = arr[i].Length - 1;
	var yLength = arr[j].Length - 1;

	for (i = 0; i <= xLength; i++, j++)
	{
		Console.WriteLine(arr[i][j]);
		sum += arr[i][j];
	}

	for (i = xLength, j = 0; i >= 0 && j <= yLength; i--, j++)
	{
		Console.WriteLine(arr[i][j]);
		sum1 += arr[i][j];
	}

	return Math.Abs(sum - sum1);
}

int[][] ConvertTo2Darray(List<List<int>> arr)
{
	int[][] trr = arr.Select(a => a.ToArray()).ToArray();
	return trr;
}

// Define other methods and classes here
