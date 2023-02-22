using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class Functions
    {
        static public int RomanToInt(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'I':
                        if (i == s.Length - 1) result++;
                        else if (s[i + 1] == 'V' || s[i + 1] == 'X') result--;
                        else { result++; }
                        break;
                    case 'V':
                        result += 5;
                        break;
                    case 'X':
                        if (i == s.Length - 1) result += 10;
                        else if (s[i + 1] == 'L' || s[i + 1] == 'C') result -= 10;
                        else { result += 10; }
                        break;
                    case 'L':
                        result += 50;
                        break;
                    case 'C':
                        if (i == s.Length - 1) result += 100;
                        else if (s[i + 1] == 'D' || s[i + 1] == 'M') result -= 100;
                        else { result += 100; }
                        break;
                    case 'D':
                        result += 500;
                        break;
                    case 'M':
                        result += 1000;
                        break;
                    default:
                        break;
                }
            }

            return result;
        }
        
        public static int[] RunningSum(int[] nums)
        {
            //int[] result = new int[nums.Length];
            //result[0] = nums[0];

            //for(int i = 1; i < nums.Length; i++)
            //{
            //    result[i] = nums[i] + result[i - 1];
            //}

            //return result;

            for (int i = 1; i < nums.Length; i++)
                nums[i] += nums[i - 1];

            return nums;
        }

        public static int MaximumWealth(int[][] accounts)
        {
            int max = 0;

            for(int i = 0; i < accounts.Length; i++)
            {
                int custWealth = accounts[i][0];
                for(int j = 1; j < accounts[i].Length; j++)
                {
                    custWealth += accounts[i][j];
                }
                if (custWealth > max) max = custWealth;
            }

            return max;
        }

        public static IList<string> FizzBuzz(int n)
        {
            List<string> list = new List<string>();

            for(int i = 1; i <= n; i++)
            {
                if (i % 15 == 0) list.Add("FizzBuzz");
                else if (i % 3 == 0) list.Add("Fizz");
                else if (i % 5 == 0) list.Add("Buzz");
                else list.Add(i.ToString());
            }

            return list;
        }

        public static int NumberOfSteps(int num)
        {
            int steps = 0;
            
            while(num != 0)
            {
                if (num % 2 == 0) num /= 2;
                else num--;
                steps++;
            }

            return steps;
        }
                
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode MiddleNode(ListNode head)
        {
            int middleIndex = 0;
            ListNode middleNode = head;

            while(head != null)
            {
                middleIndex++;
                if(middleIndex % 2 == 0) middleNode = middleNode.next;
                head = head.next;
            }

            return middleNode;
        }

        //better one
        public ListNode MiddleNode2(ListNode head)
        {
            ListNode middleNode = head;

            while ((head != null) && (head.next != null))
            {
                middleNode = middleNode.next;
                head = head.next.next;
            }

            return middleNode;
        }
    }
}
