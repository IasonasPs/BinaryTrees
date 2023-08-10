using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree.Interfaces
{
    internal interface IBinaryTree<T> where T : IComparable<T>
    {
        INode<T> Root { get; }
        INode<T> L { get; }
        INode<T> R { get; }

        void Add(T value);
        void Display(INode<T> node);
    }
}
