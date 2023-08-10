using MyTree.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree.Tree
{
    public class Node<T> : INode<T> where T : IComparable<T>
    {
        public T _value { get; set; }

        public INode<T> L { get; set; }
        public INode<T> R { get; set; }



        public Node(T value)
        {
            _value = value;
        }
    }
}
