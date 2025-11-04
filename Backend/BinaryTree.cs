namespace Backend;

public class BinaryTree
{
    public Node? Root;

    public BinaryTree()
    {
        Root = null;
    }

    public void InitTree()
    {
        Root = new Node('\0');
    }
}