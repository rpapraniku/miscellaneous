<Query Kind="Program" />

static void Main(string[] args)
{
	int[] a = new int[110005];
	int upcomingReq = 0;
	int maxNrOfReq = 0;
	int milliseconds = 0;

	string input1 = Console.ReadLine();
	if (input1 != null)
	{
		string[] split = input1.Split(' ');
		upcomingReq = int.Parse(split[0]);
		maxNrOfReq = int.Parse(split[1]);
	}

	for (int i = 0; i < upcomingReq; i++)
	{
		string input2 = Console.ReadLine();
		if (input2 != null)
		{
			milliseconds = int.Parse(input2);
		}
		a[milliseconds]++;
		a[milliseconds + 1000]--;
	}
	int sum = 0;
	int ans = 0;
	for (int i = 0; i < 110000; i++)
	{
		sum += a[i];
		ans = Math.Max(sum, ans);
	}
	Console.Write("{0:D}\n", ans % maxNrOfReq == 0 ? (ans / maxNrOfReq) : (ans / maxNrOfReq + 1));
}