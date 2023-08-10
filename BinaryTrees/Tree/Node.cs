using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees.Tree
{
    internal class Node<T>  where T : IComparable<T>
    {
        public T value { get; }

        public Node<T> Left { get; set; } = null!;
        public Node<T> Right { get; set; } = null!;

        public Node(T value)
        {
            this.value = value;
        }

        public void Display()
        {
            Console.WriteLine(value);
        }

        public void Add(T newValue)
        {
            if (newValue.CompareTo(value) < 0)
            {
                if (Left == null)
                {
                    Left = new Node<T>(newValue);
                }
                else
                {
                    Left.Add(newValue);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new Node<T>(newValue);
                }
                else
                {
                    Right.Add(newValue);
                }

            }
        }
    }
}
