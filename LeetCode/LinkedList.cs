namespace DSA
{
    internal class DSA1
    {
        public static void Main()
        {
            ListNodeOpr listNode1 = new ListNodeOpr();
            listNode1.Insert(9);
            listNode1.Insert(9);
            listNode1.Insert(9);
            listNode1.Insert(9);
            listNode1.Insert(9);
            listNode1.Insert(9);
            var k1 = listNode1.Insert(9);

            ListNodeOpr listNode2 = new ListNodeOpr();
            listNode2.Insert(9);
            listNode2.Insert(9);
            listNode2.Insert(9);
            var k2 = listNode2.Insert(9);

            //ListNodeOpr listNode1 = new ListNodeOpr();
            //listNode1.Insert(2); listNode1.Insert(4); var k1 =listNode1.Insert(3);

            //ListNodeOpr listNode2 = new ListNodeOpr();
            //listNode2.Insert(5); listNode2.Insert(6); var k2 = listNode2.Insert(4);

            Solution solution = new Solution();

            var result = solution.AddTwoNumbers(k1, k2);

            ListNodeOpr lor = new ListNodeOpr();
            lor.Show(result);

            //result.Show();
            Console.ReadLine();
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
    }

    public class ListNodeOpr
    {
        public ListNode head;
        public ListNode Insert(int val)
        {
            if (head == null)
            {
                head = new ListNode { val = val, next = null };
            }
            else
            {
                ListNode temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new ListNode { val = val, next = null };
            }
            return head;
        }

        public void Show(ListNode listNode)
        {
            if (listNode != null)
            {
                Console.WriteLine(listNode.val);
                while (listNode.next != null)
                {
                    listNode = listNode.next;
                    Console.WriteLine(listNode.val);
                }
            }
        }
    }
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode returnNode = new ListNode();
            int li1 = 0, li2 = 0, li3 = 0, rem = 0, qsnt = 0;
            ListNodeOpr returnListNode = new ListNodeOpr();
            if ((l1 == null) && (l2 == null))
            {
                return new ListNode();
            }

            li1 = l1.val; li2 = l2.val; 
            li3 = li1 + li2;
            rem = li3 % 10;
            qsnt = li3 / 10;
            returnNode = returnListNode.Insert(rem);
            while (l1.next != null || l2.next != null)
            {
                if (l1.next != null)
                {
                    l1 = l1.next;
                    li1 = l1.val;
                }
                else
                {
                    li1 = 0;
                }

                if (l2.next != null)
                {
                    l2 = l2.next;
                    li2 = l2 .val;
                }
                else
                {
                    li2 = 0;
                }
                li3 = li1 + li2 + qsnt;
                rem = li3 % 10;
                returnNode = returnListNode.Insert(rem);

                qsnt = li3 / 10;                
            }
            if (qsnt > 0)
                returnNode = returnListNode.Insert(qsnt);
            return returnNode;
        }
    }
}
