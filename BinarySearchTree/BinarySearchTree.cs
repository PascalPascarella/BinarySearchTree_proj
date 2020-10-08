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
    public int Count { get; private set; }

    public bool IsEmpty
    {
      get { return root == null; }
    }

    public BinarySearchTree()
    {
      root = null;
      Count = 0;
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
    public string Search(int value)
    {
      string results = root.Search(value);

      if (results.Contains("Value not found."))
      {
        results = "Value not found.";
      }

      return results.Substring(0, results.Length - 2);
    }
  }
}
