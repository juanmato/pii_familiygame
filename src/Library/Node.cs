using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class Node<T>
    {
        private T value;
        private List<Node<T>> children = new List<Node<T>>();

        public T Value
        {
            get { return this.value; }
        }

        public ReadOnlyCollection<Node<T>> Children
        {
            get { return this.children.AsReadOnly(); }
        }

        public Node(T value)
        {
            this.value = value;
        }

        public void AddChildren(Node<T> child)
        {
            this.children.Add(child);
        }

        public void Accept(IVisitor<T> visitor)
        {
            visitor.Visit(this);
            foreach (var item in this.children)
            {
                item.Accept(visitor);
            }
        }
    }

    public interface IVisitor<T>
    {
        void Visit(Node<T> node);
    }

    public class SumVisitor : IVisitor<int>
    {
        public int Sum { get; private set; } = 0;

        public void Visit(Node<int> node)
        {
            Sum += node.Value;
        }
    }
}    
    

   