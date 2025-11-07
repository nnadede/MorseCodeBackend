
using Backend;

BinaryTree tree = new BinaryTree();
//tree.InitTree();

if (tree.Root == null)
{
    Console.WriteLine("Tree is not initialized.");
}else
{
    Console.WriteLine("Tree is initialized.");
}

Console.WriteLine("Hello, World!");
// Console.WriteLine($"Root Node Value: {tree.Root?.Left?.Value}"); // Example to show usage


