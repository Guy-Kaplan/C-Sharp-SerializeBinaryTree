using System;

namespace ConsoleApp_tree_18._5._21
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("GuyK - start of program");
            Console.WriteLine();

            Node node4 = new Node("4");
            Node node3 = new Node("3", node4);
            Node node2 = new Node("2");
            Node node1 = new Node("1", node2, node3);
            Node myTree = node1;

            Console.WriteLine("My tree:");
            PrintTree(myTree);
            Console.WriteLine(Environment.NewLine);

            string serializedTree = SerializeTree(myTree, string.Empty);
            Console.WriteLine($"Serialized tree: {serializedTree}");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Prints the given Binary Tree
        /// </summary>
        /// <param name="root">Root Node of the given binary tree</param>
        public static void PrintTree(Node root)
        {
            if (root == null)
            {
                return;
            }
            Console.Write($"{root.Value}, ");
            PrintTree(root.Left);
            PrintTree(root.Right);
        }

        /// <summary>
        /// Converts Binary Tree to string (priority to Left)
        /// </summary>
        /// <param name="root">Root Node of the given binary tree</param>
        /// <param name="output">Init with an Empty string (string.Empty).
        /// It will become the returned string being built by this function.</param>
        /// <returns>The given Binary tree as one string</returns>
        public static string SerializeTree(Node root, string output)
        {
            if (root == null)
            {
                return string.Empty;
            }
            return root.Value + SerializeTree(root.Left, output) + SerializeTree(root.Right, output);
        }
    }
}
