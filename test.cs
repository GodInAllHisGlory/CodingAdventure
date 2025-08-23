using System;
using System.ComponentModel;

namespace CodingStuff
{
  class Program
  {

    static void Main(string[] args)
    {
      TreeNode test = new TreeNode(1,null, new TreeNode(2,new TreeNode(3)));
      List<int> res = new LeetCode().InorderTraversal(test);
      for (int i = 0; i < res.Count; i++)
      {
        Console.WriteLine(res[i]);
      }
    }

  }
}