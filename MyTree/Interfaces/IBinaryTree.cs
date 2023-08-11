using MyTree.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree.Interfaces
{
    internal interface IBinaryTree<T> where T : IComparable<T>
    {
        Node<T> Root { get; }

        void Add(T value);
    }
}
