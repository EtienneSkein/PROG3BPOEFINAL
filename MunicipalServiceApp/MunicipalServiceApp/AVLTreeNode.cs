using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApp
{
    public class AVLTree<T> where T : IComparable
    {
        private class Node
        {
            public T Key { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Height { get; set; }

            public Node(T key)
            {
                Key = key;
                Height = 1;
            }
        }

        private Node root;

        public void Insert(T key)
        {
            root = Insert(root, key);
        }

        private Node Insert(Node node, T key)
        {
            if (node == null)
                return new Node(key);

            int comparison = key.CompareTo(node.Key);

            if (comparison < 0)
                node.Left = Insert(node.Left, key);
            else if (comparison > 0)
                node.Right = Insert(node.Right, key);
            else
                return node;

            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
            return Balance(node);
        }

        public bool Contains(T key)
        {
            return Search(root, key);
        }

        private bool Search(Node node, T key)
        {
            if (node == null)
                return false;

            int comparison = key.CompareTo(node.Key);

            if (comparison < 0)
                return Search(node.Left, key);
            else if (comparison > 0)
                return Search(node.Right, key);
            else
                return true;
        }

        public IEnumerable<T> InOrderTraversal()
        {
            var result = new List<T>();
            InOrderTraversal(root, result);
            return result;
        }

        private void InOrderTraversal(Node node, List<T> result)
        {
            if (node == null) return;

            InOrderTraversal(node.Left, result);
            result.Add(node.Key);
            InOrderTraversal(node.Right, result);
        }

        private Node Balance(Node node)
        {
            int balanceFactor = GetBalanceFactor(node);

            if (balanceFactor > 1)
            {
                if (GetBalanceFactor(node.Left) < 0)
                    node.Left = RotateLeft(node.Left);

                return RotateRight(node);
            }

            if (balanceFactor < -1)
            {
                if (GetBalanceFactor(node.Right) > 0)
                    node.Right = RotateRight(node.Right);

                return RotateLeft(node);
            }

            return node;
        }

        private Node RotateRight(Node y)
        {
            Node x = y.Left;
            Node T2 = x.Right;

            x.Right = y;
            y.Left = T2;

            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;

            return x;
        }

        private Node RotateLeft(Node x)
        {
            Node y = x.Right;
            Node T2 = y.Left;

            y.Left = x;
            x.Right = T2;

            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;

            return y;
        }

        private int GetHeight(Node node)
        {
            return node?.Height ?? 0;
        }

        private int GetBalanceFactor(Node node)
        {
            return GetHeight(node.Left) - GetHeight(node.Right);
        }
    }


}
