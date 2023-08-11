using MyTree.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree.Interfaces
{
    internal interface INode<T> where T : IComparable<T>
    {
        T _value { get; }

        public Node<T> Left { get;  }
        public Node<T> Right { get;  }

        public void Add(T value);
        public void Display();
    }
}
