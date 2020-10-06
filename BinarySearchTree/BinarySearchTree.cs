using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace BinarySearchTree
{
	class BinarySearchTree
	{
    private Node root;

    public BinarySearchTree()
    {
      root = null;
      Count = 0;
    }

    public int Count { get; private set; }

    public bool IsEmpty
    {
      get { return root == null; }
    }

    public void Add(int value)
    {
      if (!IsEmpty)
      {
        root.Add(value);
        Count++;
      }
      else
      {
        root = new Node(value);
        Count++;
      }
    }
  }
}
