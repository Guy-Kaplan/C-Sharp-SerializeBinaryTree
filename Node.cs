using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_tree_18._5._21
{
    public class Node
    {
        // class for a Binary Tree Node
        public string Value;
        public Node Right;
        public Node Left;

        public Node(string value, Node left = null, Node right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
}
