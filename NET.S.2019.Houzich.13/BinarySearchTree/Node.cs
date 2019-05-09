using System;
using System.Collections.Generic;

namespace NET.S._2019.Houzich._13.BinarySearchTree
{
    public class Node<T>
    {
        public Node<T> Parent { get; set; }

        public Node<T> Left { get; set; }

        public Node<T> Rigth { get; set; }

        public T Value { get; set; }
    }
}
