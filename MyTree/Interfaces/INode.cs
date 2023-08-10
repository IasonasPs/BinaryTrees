using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree.Interfaces
{
    public interface INode<T> where T : IComparable<T>
    {
        T value { get; }

        INode<T> L { get; set; }
        INode<T> R { get; set; }

        void Add(T value);
    }
}
