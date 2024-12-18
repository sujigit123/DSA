class Solution {
    // Function to check if the linked list has a loop.
    public static boolean detectLoop(Node head) {
    if (head != null) {
        Node tempNode = head;
        Node fastNode = head;                
        while (tempNode.next != null) {
            tempNode = tempNode.next;                    
            if (fastNode != null)
            {
                if(fastNode.next!=null)
                {
                    fastNode = fastNode.next.next;
                }
                else
                {
                    fastNode = null;
                }
            }
            if (tempNode.equals(fastNode)) {                        
                return true;
            }
            if (fastNode == null) {
                return false;
            }
        }
    }
    return false;
    // code here
    // remove the loop without losing any nodes
}

}
