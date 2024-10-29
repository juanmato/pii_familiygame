namespace Library;

public class sumeagevisitor
{
   public void Visit(Node<Person> node)
    sumeagevisitor : IVisitor<Person>
}
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
         sum += node.number;
     }