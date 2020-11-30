using System;

namespace CodingTools
{
     public class ListNode {
        public int val { get; }
        public ListNode next { get; set; }
        public ListNode(int x) {
            val = x;
            next = null;
        }
     }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class VendingMachine
    {
        InputMoney _inputMoneyState;
        public VendingMachine()
        {
            _inputMoneyState = new InputMoney(this);
        }
    }

    public class InputMoney
    {
        VendingMachine _vendingMachine;

        public InputMoney(VendingMachine vendingMachine)
        {
            _vendingMachine = vendingMachine;
        }
    }

    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode current = head;
            ListNode currentHead = head;

            // While next is not null
            while (current.next != null)
            {
                // Make current node head
                // Point current node "next" to current head
                current.next.next = current;
                // Change current head reference to new head
                currentHead = current.next;

                current = current.next;
            }

            head.next = null;

            return currentHead;
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            int maxLeft = root.left == null ? 0 : MaxDepth(root.left);
            int maxRight = root.right == null ? 0 : MaxDepth(root.right);

            return (Math.Max(maxLeft, maxRight) + 1);
        }

        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode swappedA;
            ListNode swappedB;
            ListNode c;

            if (head.next.next != null)
                c = SwapPairs(head.next.next);
            else
                c = null;

            swappedA = head.next;
            swappedB = head;

            swappedA.next = swappedB;
            swappedB.next = c;

            return swappedA;
        }

        public ListNode BuildLinkedList(int[] list)
        {
            ListNode head = null;
            ListNode current;

            foreach(int val in list)
            {
                // Create new node
                // Traverse from head add at end
                if (head == null)
                    head = new ListNode(val);
                else
                {
                    current = head;
                    while(current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = new ListNode(val);
                }
            }

            return head;
        }

        public void OutputLinkedList(ListNode head)
        {
            ListNode current = head;

            while(current != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution linkedList = new Solution();
            ListNode head = linkedList.BuildLinkedList(new int[] { 10, 7, 11, 13 });
            head = linkedList.SwapPairs(head);
            linkedList.OutputLinkedList(head);

            Console.ReadLine();
        }
    }
}
