using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class RedBlackTree
    {
        public Node root;

        public bool Add(int value)
        {
            if (root != null) 
            {
                bool result = AddNode(root, value);
                root = Rebalance(root);
                root.color = Color.BLACK;
                return result;
            }
            else
            {
                root = new Node();
                root.color = Color.BLACK;
                root.value = value;
                return true;
            }
        }

        public bool AddNode(Node node, int value)
        {
            if (node.value == value) 
            {
                return false;
            }
            else
            {
                if (node.value > value)
                {
                    if (node.leftChild != null)
                    {
                        bool result = AddNode(node.leftChild, value);
                        node.leftChild = Rebalance(node.leftChild);
                        return result;
                    }
                    else
                    {
                        node.leftChild = new Node();
                        node.leftChild.color = Color.RED;
                        node.leftChild.value = value;
                        return true;
                    }
                }
                else
                {
                    if (node.rightChild != null)
                    {
                        bool result = AddNode(node.rightChild, value);
                        node.rightChild = Rebalance(node.rightChild);
                        return result;
                    }
                    else
                    {
                        node.rightChild = new Node();
                        node.rightChild.color = Color.RED;
                        node.rightChild.value = value;
                        return true;
                    }
                }
            }
        }

        public Node Rebalance(Node node)
        {
            Node result = node;
            bool needBalance;
            do
            {
                needBalance = false;
                if (result.rightChild != null && result.rightChild.color == Color.RED && (result.leftChild == null || result.leftChild.color == Color.BLACK))
                {
                    needBalance = true;
                    result = RightSwap(result);
                }
                if (result.leftChild != null && result.leftChild.color == Color.RED && result.leftChild.leftChild != null && result.leftChild.leftChild.color == Color.RED)
                {
                    needBalance = true;
                    result = LeftSwap(result);
                }
                if (result.leftChild != null && result.leftChild.color == Color.RED && result.rightChild != null && result.rightChild.color == Color.RED)
                {
                    needBalance = true;
                    ColorSwap(result);
                }
            }
            while (needBalance);
            return result;
        }

        public Node LeftSwap(Node node)
        {
            Node leftChild = node.leftChild;
            Node beetweenChild = node.rightChild;
            leftChild.rightChild = node;
            node.leftChild = beetweenChild;
            leftChild.color = node.color;
            node.color = Color.RED;
            return leftChild;
        }

        public Node RightSwap(Node node)
        {
            Node rightChild = node.rightChild;
            Node berweenChild = node.leftChild;
            rightChild.leftChild = node;
            node.rightChild = berweenChild;
            rightChild.color = node.color;
            node.color = Color.RED;
            return rightChild;
        }

        public void ColorSwap(Node node)
        {
            node.leftChild.color = Color.BLACK;
            node.rightChild.color = Color.BLACK;
            node.color = Color.RED;
        }
    }
}
