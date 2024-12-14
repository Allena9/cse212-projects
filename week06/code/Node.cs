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
        if (Contains(value))
        {
            return; // Value already exists, do not insert
        }

        if (value < Data)
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
        if (value == Data)
            return true;
        else if (value < Data)
            return Left != null && Left.Contains(value);
        else
            return Right != null && Right.Contains(value);
    }

    public int GetHeight()
    {
        if (Left is null && Right is null)
            return 1;
        else if (Left is null && Right is not null)
            return 1 + Right.GetHeight();
        else if (Right is null && Left is not null)
            return 1 + Left.GetHeight();
        else
            return 1 + Math.Max(Left.GetHeight(), Right.GetHeight());
    }
}