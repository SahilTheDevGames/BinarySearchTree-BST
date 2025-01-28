using UnityEngine;

public class TreeNode
{
    public int Value;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int value)
    {
        Value = value;
    }
}

public class Tree : MonoBehaviour
{
    public TreeNode Root;

    public void Insert(int value)
    {
        Root = InsertRecursively(Root, value);
    }

    private TreeNode InsertRecursively(TreeNode node, int value)
    {
        if (node == null) return new TreeNode(value);

        if (value < node.Value)
        {
            node.Left = InsertRecursively(node.Left, value);
        }
        else
        {
            node.Right = InsertRecursively(node.Right, value);
        }

        return node;
    }

    public void InOrderTraversal(TreeNode node)
    {
        if (node == null) return;

        InOrderTraversal(node.Left);
        Debug.Log(node.Value);
        InOrderTraversal(node.Right);
    }

    private void Start()
    {
        int[] numberList = { 3, 2, 1, 4, 5 };

        foreach (int number in numberList)
        {
            Insert(number);
        }

        Debug.Log("In-order traversal of the tree:");
        InOrderTraversal(Root);
    }
}
