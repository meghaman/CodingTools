using System.Collections.Generic;

namespace CodingTools.Algorithms
{
    public class GraphNode
    {
        public List<GraphNode> children;
        public int total;

        public GraphNode()
        {
            children = new List<GraphNode>();
        }
    }

    public class BFSearch
    {
        public List<int> Search(GraphNode root)
        {
            List<int> orderedList = new List<int>();
            Queue<GraphNode> queue = new Queue<GraphNode>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                GraphNode currentNode = queue.Dequeue();
                orderedList.Add(currentNode.total);
                currentNode.children.ForEach(child => queue.Enqueue(child));
            }

            return orderedList;
        }
    }

    public class DFSearch
	{
        public List<int> Search(GraphNode root)
        {
            List<int> orderedList = new List<int>();
            Stack<GraphNode> stack = new Stack<GraphNode>();

            stack.Push(root);

            while (stack.Count > 0)
            {
                GraphNode currentNode = stack.Pop();
                orderedList.Add(currentNode.total);
                currentNode.children.ForEach(child => stack.Push(child));
            }

            return orderedList;
        }
    }
} 
