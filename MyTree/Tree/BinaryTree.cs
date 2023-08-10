using MyTree.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree.Tree
{
    internal class BinaryTree<T> : IBinaryTree<T> where T : IComparable<T>
    {
        public INode<T> Root { get; set; }
        public INode<T> L { get; set; }
        public INode<T> R { get; set; }

        public void Add(T value)
        {
            if (Root == null)
            {
                Root = new Node<T>(value);
            }
            else 
            {
                Root.Add(value);
                //if (value.CompareTo(Root._value) <= 0)
                //{
                //    L = new Node<T>(value);
                //}
                //else
                //{
                //    R = new Node<T>(value);
                //}
            }
        }

        public void Display(INode<T> node)
        {
            throw new NotImplementedException();
        }
    }
}
