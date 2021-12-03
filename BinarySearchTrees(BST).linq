<Query Kind="Program" />

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;

	public TreeNode(int val)
	{
		this.val = val;
	}

	public TreeNode(int val, TreeNode left, TreeNode right)
	{
		this.val = val;
		this.left = left;
		this.right = right;
	}
}

void Main()
{
	TreeNode[] root = new TreeNode[7];
	root[0] = new TreeNode(10);

	root[1] = new TreeNode(5);
	root[2] = new TreeNode(15);
	root[3] = new TreeNode(3);
	root[4] = new TreeNode(7);
	root[5] = null;
	root[6] = new TreeNode(18);

	root[0].left = root[1];
	root[0].right = root[2];
	root[1].left = root[3];
	root[1].right = root[4];
	root[2].right = root[6];

	var ts1 = new Stopwatch();
	var ts2 = new Stopwatch();

	ts1.Start();
	var v1 = RangeSumBST(root[0], 7, 15);
	ts1.Stop();

	Console.WriteLine($"FIRST APPROACH - {v1} - in {ts1.Elapsed} milisec");

	ts2.Start();
	var v2 = RangeSumBSTV1(root, 7, 15);
	ts2.Stop();
	Console.WriteLine($"SECOND APPROACH - {v2} - in {ts2.Elapsed} milisec");


}

public int RangeSumBSTV1(TreeNode[] root, int low, int high)
{
	int sum = 0;

	if (root == null)
	{
		return sum;
	}

	Queue<TreeNode> queue = new Queue<TreeNode>();
	queue.Enqueue(root[0]);

	while (queue.Count != 0)
	{
		TreeNode node = queue.Dequeue();

		if (node.val >= low && node.val <= high)
		{
			sum += node.val;
		}

		if (node.left != null)
		{
			queue.Enqueue(node.left);
		}
		if (node.right != null)
		{
			queue.Enqueue(node.right);
		}
	}

	return sum;
}

int sum = 0;
public int RangeSumBST(TreeNode root, int low, int high)
{
	if (root == null)
	{
		return sum;
	}

	CalculateSum(root, low, high);

	return sum;
}

private void CalculateSum(TreeNode root, int low, int high)
{
	if (root == null)
	{
		return;
	}

	CalculateSum(root.left, low, high);

	if (root.val >= low && root.val <= high)
	{
		sum = sum + root.val;
	}

	CalculateSum(root.right, low, high);
}
// Define other methods and classes here
