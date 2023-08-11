using MyTree.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree.Tree
{
    internal class Node<T> : INode<T> where T : IComparable<T>
    {

        public T _value { get; private set; }


        public Node<T> Left { get; private set; }
        public Node<T> Right { get; private set; }

        public Node(T value)
        {
            _value = value;
        }

        public void Add(T value)
        {
            if (value.CompareTo(_value) <= 0)
            {
                if (Left == null)
                {
                    Left = new Node<T>(value);
                }
                else
                {
                    Left.Add(value);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new Node<T>(value);
                }
                else
                {
                    Right.Add(value);
                }
            }

        }

        public void Display()
        {
            Console.WriteLine(_value);
        }
    }
}
