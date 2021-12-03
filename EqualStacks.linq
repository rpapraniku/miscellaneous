<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
</Query>

void Main()
{
	var s1 = new int[] { 3, 2, 1, 1, 1 };
	var s2 = new int[] { 4, 3, 2 };
	var s3 = new int[] { 1, 1, 4, 1 };

	Console.WriteLine(EqualStacks(s1, s2, s3));
}
public int EqualStacks(int[] s1, int[] s2, int[] s3)
{
	var stack1 = new Stack<int>();
	var stack2 = new Stack<int>();
	var stack3 = new Stack<int>();

	int maxHeight = 0;

	fillStacks(stack1, s1, stack2, s2, stack3, s3);

	while (stack1.Count != 0 && stack2.Count != 0 && stack3.Count != 0)
	{
		if (stack1.Peek() == stack2.Peek() && stack2.Peek() == stack3.Peek())
		{
			maxHeight = stack1.Peek();
			break;
		}

		if (stack1.Peek() >= stack2.Peek() && stack1.Peek() >= stack3.Peek())
		{
			stack1.Pop();
			continue;
		}
		else if (stack2.Peek() >= stack1.Peek() && stack2.Peek() >= stack3.Peek())
		{
			stack2.Pop();
			continue;
		}
		else if (stack3.Peek() >= stack1.Peek() && stack3.Peek() >= stack2.Peek())
		{
			stack3.Pop();
			continue;
		}
	}

	return maxHeight;
}

void fillStacks(Stack<int> stack1, int[] s1, Stack<int> stack2, int[] s2, Stack<int> stack3, int[] s3)
{
	foreach (var element in s1)
	{
		if (stack1.Count == 0)
		{
			stack1.Push(element);
			continue;
		}

		var previous = stack1.Peek();
		stack1.Push(previous + element);
	}

	foreach (var element in s2)
	{
		if (stack2.Count == 0)
		{
			stack2.Push(element);
			continue;
		}

		var previous = stack2.Peek();
		stack2.Push(previous + element);

	}

	foreach (var element in s3)
	{
		if (stack3.Count == 0)
		{
			stack3.Push(element);
			continue;
		}

		var previous = stack3.Peek();
		stack3.Push(previous + element);
	}
}


// Define other methods and classes here
