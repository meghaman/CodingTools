using System;

namespace CodingTools
{
    public class BinaryNode
    {
        public int Value { get; set; }
        public BinaryNode Left { get; set; }
        public BinaryNode Right { get; set; }

        public void AddNode(int _value)
        {
            AddNode(new BinaryNode() { Value = _value });
        }

        public void AddNode(BinaryNode _node)
        {
            if(Compare(_node))
            {
                if (Left != null)
                    Left.AddNode(_node);
                else
                    Left = _node;
            }
            else
            {
                if (Right != null)
                    Right.AddNode(_node);
                else
                    Right = _node;

            }
        }

        private bool Compare(BinaryNode _node)
        {
            if (Value > _node.Value)
                return true;
            else
                return false;
        }
    }

    public class BinaryTreeTools
    {
        public BinaryNode InvertTree(BinaryNode root)
        {
            if (root.Left != null)
                InvertTree(root.Left);
            if (root.Right != null)
                InvertTree(root.Right);

            BinaryNode temporaryNode = root.Left;
            root.Left = root.Right;
            root.Right = temporaryNode;

            return root;
        }

        public void InOrder(BinaryNode root)
        {
            if (root == null)
                return;

            InOrder(root.Left);
            Console.WriteLine(root.Value);
            InOrder(root.Right);
        }

         
    }
}
