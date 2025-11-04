namespace Backend
{
    public class Node
    {
        public char Value;
        public Node? Left, Right;

        public Node(char value)
        {
            Value = value;
            Left = Right = null;
        }
    }
}