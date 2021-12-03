<Query Kind="Program" />

void Main()
{
	var arr = new LinkedList<int>(new[] { 1, 2, 2, 3, 4, 4 });

	var xxx = removeDuplicates(arr.First);

	Console.WriteLine(xxx);
}

LinkedListNode<int> removeDuplicates(LinkedListNode<int> head)
{
	var duplicates = new Hashtable();
	LinkedListNode<int> node = head;
	LinkedListNode<int> previous = null;

	while (node != null)
	{
		if (duplicates.ContainsKey(node.Value)
		{
			if (node.Value == node.Next.Value)
			{
				temp = temp.Next;
				continue;
			}

		}
		else
		{
		}

	}
}

// Define other methods and classes here