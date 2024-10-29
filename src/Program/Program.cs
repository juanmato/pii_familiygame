using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> n1 = new Node(1);
            Node<int> n2 = new Node(2);
            Node<int> n3 = new Node(3);
            Node<int> n4 = new Node(4);
            Node<int> n5 = new Node(5);
            Node<int> n6 = new Node(6);
            Node<int> n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
            SumVisitor visitor = new SumVisitor();
            n1.Accept(visitor);
            Console.WriteLine(visitor.Sum);
        }
    }
}
