public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        Node _root = this;
        if (_root.Data == null)
        {
            _root.Data = value;
        }
        else if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        return value == Data || (value < Data && Left != null && Left.Contains(value)) || (value > Data && Right != null && Right.Contains(value));
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        // return 0; // Replace this line with the correct return statement(s)
        Node node = this;
        if (node == null)
        {
            return 0;
        }
        return 1 + Math.Max(node.Left != null ? node.Left.GetHeight() : 0, node.Right != null ? node.Right.GetHeight() : 0);
    }
}