namespace Library;

public class SumVisitor: IVisitor
{
    private int sum = 0;

    public int Sum
    {
        get
        {
            return this.sum;
        }
    }

    public void Visit(Node<T> node)
    {
        sum += node.member;
    }
}
