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
        // Level 0
        Root = new Node('\0');
        // Level 1
        Root.Left = new Node('E');
        Root.Right = new Node('T');
        // Level 2
        Root.Left.Left = new Node('I');
        Root.Left.Right = new Node('A');
        Root.Right.Left = new Node('N');
        Root.Right.Right = new Node('M');
        // Level 3
        Root.Left.Left.Left = new Node('S');
        Root.Left.Left.Right = new Node('U');
        Root.Left.Right.Left = new Node('R');
        Root.Left.Right.Right = new Node('W');
        Root.Right.Left.Left = new Node('D');
        Root.Right.Left.Right = new Node('K');
        Root.Right.Right.Left = new Node('G');
        Root.Right.Right.Right = new Node('O');
        // Level 4
        Root.Left.Left.Left.Left = new Node('H');
        Root.Left.Left.Left.Right = new Node('V');
        Root.Left.Left.Right.Left = new Node('F');
        Root.Left.Left.Right.Right = new Node('#');
        Root.Left.Right.Left.Left = new Node('L');
        Root.Left.Right.Left.Right = new Node('#');
        Root.Left.Right.Right.Left = new Node('P');
        Root.Left.Right.Right.Right = new Node('J');
        Root.Right.Left.Left.Left = new Node('B');
        Root.Right.Left.Left.Right = new Node('X');
        Root.Right.Left.Right.Left = new Node('C');
        Root.Right.Left.Right.Right = new Node('Y');
        Root.Right.Right.Left.Left = new Node('Z');
        Root.Right.Right.Left.Right = new Node('Q');
        Root.Right.Right.Right.Left = new Node('#');
        Root.Right.Right.Right.Right = new Node('#');
        // Level 5
        // Numbers and arithmetic symbols
        Root.Left!.Left!.Left!.Left!.Left = new Node('5');
        Root.Left!.Left!.Left!.Left!.Right = new Node('4');
        Root.Left!.Left!.Left!.Right!.Right = new Node('3');
        Root.Left!.Left!.Right!.Right!.Left = new Node('#');
        Root.Left!.Left!.Right!.Right!.Right = new Node('2');
        Root.Left!.Right!.Left!.Left!.Left = new Node('&');
        Root.Left!.Right!.Left!.Left!.Right = new Node('#');
        Root.Left!.Right!.Left!.Right!.Left = new Node('+');
        Root.Left!.Right!.Right!.Left!.Right = new Node('#');
        Root.Left!.Right!.Right!.Right!.Right = new Node('1');
        Root.Right!.Left!.Left!.Left!.Left = new Node('6');
        Root.Right!.Left!.Left!.Left!.Right = new Node('=');
        Root.Right!.Left!.Left!.Right!.Left = new Node('/');
        Root.Right!.Left!.Right!.Left!.Right = new Node('#');
        Root.Right!.Left!.Right!.Right!.Left = new Node('(');
        Root.Right!.Right!.Left!.Left!.Left = new Node('7');
        Root.Right!.Right!.Left!.Left!.Right = new Node('#');
        Root.Right!.Right!.Right!.Left!.Left = new Node('8');
        Root.Right!.Right!.Right!.Right!.Left = new Node('9');
        Root.Right!.Right!.Right!.Right!.Right = new Node('0');
        // Level 6
        // Punctuation and Special Characters
        Root.Left!.Left!.Right!.Right!.Left!.Left = new Node('?');
        Root.Left!.Left!.Right!.Right!.Left!.Right = new Node('_');
        Root.Left!.Right!.Left!.Left!.Right!.Left = new Node('"');
        Root.Left!.Right!.Left!.Right!.Left!.Right = new Node('.');
        Root.Left!.Right!.Right!.Left!.Right!.Left = new Node('@');
        Root.Left!.Right!.Right!.Right!.Right!.Left = new Node('\'');
        Root.Right!.Left!.Left!.Left!.Left!.Right = new Node('-');
        Root.Right!.Left!.Right!.Left!.Right!.Left = new Node(';');
        Root.Right!.Left!.Right!.Left!.Right!.Right = new Node('!');
        Root.Right!.Left!.Right!.Right!.Left!.Right = new Node(')');
        Root.Right!.Right!.Left!.Left!.Right!.Right = new Node(',');
        Root.Right!.Right!.Right!.Left!.Left!.Left = new Node(':');
    }
}