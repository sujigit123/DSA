public class Node1
 {
     public int data;
     public Node1 next;
 }
 public class Class2
 {
     Node1 head;
     public static void Main()
     {
         Class2 class2 = new Class2();
         //class2.IsLoopPresentInLinkedList(null);
         class2.InsertAtEnd(new Node1 { data = 1, next = null });
         class2.InsertAtEnd(new Node1 { data = 2, next = null });
         Node1 n1 = new Node1 { data = 3, next = null };
         class2.InsertAtEnd(n1);

         class2.InsertAtEnd(new Node1 { data = 4, next = null });
         class2.InsertAtEnd(new Node1 { data = 5, next = null });
         class2.InsertAtEnd(new Node1 { data = 6, next = null });
         //class2.InsertAtPosition(new Node1 { data = 17, next = null }, 2);
         class2.InsertAtEnd(new Node1 { data = 7, next = n1 });
         //Console.WriteLine($"Is this circular LinkedList : {class2.IsCircularLinkedList(class2.head)}");
         Class2.removeLoop(class2.head);
         Console.WriteLine($"Is loop present in LinkedList : {class2.IsLoopPresentInLinkedList(class2.head)}");
         class2.Show();
         Console.ReadLine();
     }

     public bool IsCircularLinkedList(Node1 node1)
     {
         if (node1 != null)
         {
             Node1 nodeTemp = node1;

             while (node1.next != null)
             {
                 node1 = node1.next;
                 if (node1 == nodeTemp)
                 {
                     return true;
                 }
             }
         }

         return false;
     }

     public bool IsLoopPresentInLinkedList(Node1 node1)
     {
         if (node1 != null)
         {
             List<Node1> listNode1 = new List<Node1>();
             listNode1.Add(node1);
             while (node1.next != null)
             {
                 node1 = node1.next;
                 if (listNode1.Contains(node1))
                 {
                     return true;
                 }
                 listNode1.Add(node1);
             }
         }

         return false;
     }

     public void InsertAtEnd(Node1 node1)
     {
         if (head == null)
         {
             head = node1;
         }
         else
         {
             Node1 temp = head;

             while (temp.next != null)
             {
                 temp = temp.next;
             }
             temp.next = node1;
         }
     }

     public void InsertAtBegining(Node1 node1)
     {
         if (head == null)
         {
             head = node1;
         }
         else
         {
             node1.next = head;
             head = node1;
         }
     }

     public void InsertAtPosition(Node1 node1, int position)
     {
         if (position == 0)
         {
             InsertAtBegining(node1);
             return;
         }

         if (head == null)
         {
             head = node1;
         }
         else
         {
             int positionCounter = 1;
             Node1 temp = head;
             while (temp.next != null)
             {
                 if (positionCounter == position)
                 {
                     Node1 temp2 = temp.next;
                     temp.next = node1;
                     node1.next = temp2;
                     return;
                 }
                 temp = temp.next;
                 positionCounter++;
             }
             temp.next = node1;
         }
     }

     public void Show()
     {
         if (head != null)
         {
             Console.WriteLine(head.data);
             while (head.next != null)
             {
                 head = head.next;
                 Console.WriteLine(head.data);
                 Thread.Sleep(1000);
             }
         }
     }

     public static void removeLoop(Node1 head)
     {
         if (head != null)
         {
             Node1 tempNode = head;
             List<Node1> listNode1 = new List<Node1>();
             listNode1.Add(tempNode);
             while (tempNode.next != null)
             {
                 tempNode = tempNode.next;
                 if (listNode1.Contains(tempNode.next))
                 {
                     tempNode.next = null;
                     return;
                 }
                 listNode1.Add(tempNode);
             }
         }

         // code here
         // remove the loop without losing any nodes
     }
 }
