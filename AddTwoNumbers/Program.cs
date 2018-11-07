
namespace AddTwoNumbers
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode resultNode = new ListNode(0);
            ListNode currentNode = resultNode;
            ListNode next1 = l1;
            ListNode next2 = l2;
            bool sum10 = false;

            do
            {

                int val1 = (next1 == null ? 0 : next1.val);
                int val2 = (next2 == null ? 0 : next2.val);

                int sum = 0;
                if (sum10)
                {
                    sum = val1 + val2 + 1;
                }
                else
                {
                    sum = val1 + val2;
                }


                if (sum >= 10)
                {
                    currentNode.val += (sum - 10);
                    sum10 = true;
                }
                else
                {
                    currentNode.val += sum;
                    sum10 = false;
                }



                if (next1 == null && next2 == null)
                {
                    if (sum10 == false)
                    {
                        currentNode.next = null;
                    }
                    else
                    {
                        currentNode.next = new ListNode(0);
                    }

                }
                if (next1 != null && next2 == null)
                {
                    if (next1.next == null && sum10 == false)
                    {
                        currentNode.next = null;
                    }
                    else
                    {
                        currentNode.next = new ListNode(0);
                    }

                }
                if (next1 == null && next2 != null)
                {
                    if (next2.next == null && sum10 == false)
                    {
                        currentNode.next = null;
                    }
                    else
                    {
                        currentNode.next = new ListNode(0);
                    }

                }
                if (next1 != null && next2 != null)
                {
                    if ((next1.next == null) && (next2.next == null) && (sum10 == false))
                    {
                        currentNode.next = null;
                    }
                    else
                    {
                        currentNode.next = new ListNode(0);
                    }

                }







                currentNode = currentNode.next;
                if (next1 != null)
                {
                    next1 = next1.next;
                }
                else
                {
                    next1 = null;
                };

                if (next2 != null)
                {
                    next2 = next2.next;
                }
                else
                {
                    next2 = null;
                }




            } while (currentNode != null || (sum10 == true));
            return resultNode;


        }
    }
}