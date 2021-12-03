<Query Kind="Program" />

void Main()
{
	List<string> list = new List<string>()
	{
	 "eabcd"
	,"fghij"
	,"olkmn"
	,"trpqs"
	,"xywuv"
	
		//"mpxz"
		//,"abcd"
		//,"wlmf"
	};

	char[][] arr = list.Select(s => s.ToCharArray()).ToArray();
	var r = arr.GetLength(0);
	var c = arr[0].Length;

	foreach (var element in arr)
	{
		Array.Sort(element);
	}

	Console.WriteLine($"r [{r}] - c [{c}]");
	for (int i = 0; i < c && i < r; i++)
	{
		for (int j = 0; j < r - 1 && j < c; j++)
		{
			Console.WriteLine($"[{j}][{i}] - [{j + 1}][{i}]");
			if ((int)arr[j][i] > (int)arr[j + 1][i])
			{
				Console.WriteLine("NO");
				break;
			}
		}
	}

	Console.WriteLine("YES");
}

public static void RearrangeRecursion(ref char[][] arr, int row, int n)
{
	if (arr.Length == row)
	{
		return;
	}

	for (int j = 0; j < n - 1; j++)
	{
		swap(ref arr[row][j], ref arr[row][j + 1]);
		RearrangeRecursion(ref arr, row + 1, n);
	}
}

public static void swap(ref char v1, ref char v2)
{
	var temp = v1;
	v1 = v2;
	v2 = temp;
}
// Define other methods and classes here
