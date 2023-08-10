﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree.Tree
{
    internal class BinaryTree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; set; }


        public void Add(T value) 
        {
            if (Root == null)
            {
                Root = new Node<T>(value);
            }
            else
            {
                Root.Add(value);
            }
        }
    }
}
