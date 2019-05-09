using System;
using System.Collections.Generic;

namespace NET.S._2019.Houzich._13.BinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private Node<T> _root;

        public Node<T> Insert(Node<T> root, T v)
        {
            if (root == null)
            {
                _root = new Node<T>
                {
                    Value = v
                };
            }
            else if (v.CompareTo(_root.Value) < 0)
            {
                var node = new Node<T>
                {
                    Value = v,
                };
                root.Left = node;
            }
            else
            {
                var node = new Node<T>
                {
                    Value = v,
                };
                root.Rigth = node;
            }

            return root;
        }

        public IEnumerable<Node<T>> PreorderTraversal(Node<T> node = null)
        {
            if (node == null)
            {
                node = _root;
            }

            yield return node;

            if (node.Left != null)
            {
                var left = PreorderTraversal(node.Left);
                foreach (var l in left)
                {
                    yield return l;
                }
            }

            if (node.Rigth != null)
            {
                var right = PreorderTraversal(node.Left);
                foreach (var r in right)
                {
                    yield return r;
                }
            }
        }

        public IEnumerable<Node<T>> InorderTraversal(Node<T> node = null)
        {
            if (node == null)
            {
                node = _root;
            }

            if (node.Left != null)
            {
                var left = PreorderTraversal(node.Left);
                foreach (var l in left)
                {
                    yield return l;
                }
            }

            yield return node;

            if (node.Rigth != null)
            {
                var right = PreorderTraversal(node.Left);
                foreach (var r in right)
                {
                    yield return r;
                }
            }
        }

        public IEnumerable<Node<T>> PostorderTraversal(Node<T> node = null)
        {
            if (node == null)
            {
                node = _root;
            }

            if (node.Left != null)
            {
                var left = PostorderTraversal(node.Left);
                foreach (var l in left)
                {
                    yield return l;
                }
            }

            if (node.Rigth != null)
            {
                var right = PostorderTraversal(node.Left);
                foreach (var r in right)
                {
                    yield return r;
                }
            }

            yield return node;
        }
    }
}
