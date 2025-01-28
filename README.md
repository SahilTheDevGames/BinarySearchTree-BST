# Binary Search Tree Implementation in C# (Unity Version)

This repository contains an implementation of a Binary Search Tree (BST) in C#, adapted for use in Unity. It includes a basic `TreeNode` class to represent each node and a `Tree` class to manage the insertion of values into the BST.

## Code Overview

### TreeNode Class

The `TreeNode` class represents a single node in the binary search tree. Each node stores an integer value and has references to its left and right child nodes.

```csharp
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
```

### Tree Class

The `Tree` class provides the functionality to build and manage the binary search tree. It includes an `Insert` method to add elements to the tree.

#### Insert Method
The `Insert` method is a recursive function that:
- Adds a new node if the current node is null.
- Compares the new value with the current node's value to decide whether to place the new value in the left or right subtree.

#### Example Scene Setup in Unity
The `Tree` functionality can be tested in a Unity project by creating a GameObject and attaching a MonoBehaviour script that utilizes the tree.

```csharp
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
```

## How to Use in Unity
1. Create a new Unity project or open an existing one.
2. Create a new C# script (e.g., `Tree.cs`) and paste the code above.
3. Attach the script to a GameObject in your Unity scene.
4. Press Play to see the in-order traversal output in the Unity Console.

## Example Usage in Unity
This binary search tree can be useful for gameplay mechanics, such as:
1. Storing and retrieving hierarchical data.
2. Managing a sorted list of scores or player statistics.
3. Implementing custom data structures for AI behaviors or other gameplay features.
