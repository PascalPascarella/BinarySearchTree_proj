using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace BinarySearchTree
{
	class Node
	{
    public Node Left { get; set; }

    public Node Right { get; set; }

    public int Value { get; }

    public Node(int value)
    {
      this.Value = value;
      Left = null;
      Right = null;
    }

    public void Add(int value)
    {
      if (value == Value)   // Prevents duplicate values by comparing incoming value against a node Value
      {
        return;
      }

      if (value < Value)    // Checks against current node's Value for Left movement
      {
        if (Left == null)   // No node below current Value
        {
          Left = new Node(value);
        }
        else
        {
          Left.Add(value);
        }
      }

      if (value > Value)    // Checks against current node's Value for Right movement
      {
        if (Right == null)    // No node below current Value
        {
          Right = new Node(value);
        }
        else
        {
          Right.Add(value);
        }
      }
    }
  }
}
