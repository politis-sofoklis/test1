using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise1
{
    static class Utilities
    {

        static public void Swap(ref int x, ref int y)
        {
            int temp = y;
            y = x;
            x = temp;
        }
        static public void SwapGen<T>(ref T x, ref T y)
        {
            T temp = y;
            y = x;
            x = temp;
        }
         static public List<int> LongestSubs(List<int> list)
        {
            List<int> longest = new List<int>{list[0]};
            List<int> templongest = new List<int> {list[0]};
            for (int i = 0; i < (list.Count-1); i++)
            {
                if (list[i + 1] == list[i])
                {
                    templongest.Add(list[i+1]);
                }
                else
                {
                    templongest = new List<int> { list[i+1] };
                }
                if (templongest.Count > longest.Count)
                {
                    longest = templongest;
                    
                }
            }
            return longest;
        }

        static public List<T> LongestSubsGen<T>(List<T> list)

        {
            List<T> longest = new List<T> { list[0] };
            List<T> templongest = new List<T> { list[0] };
            for (int i = 0; i < list.Count -1; i++)
            {
                if (list[i + 1].Equals(list[i]))
                {
                    templongest.Add(list[i + 1]);
                }
                else
                {
                    templongest = new List<T> { list[i + 1] };
                }
                if (templongest.Count > longest.Count)
                {
                    longest = templongest;
                }

            }
            return longest;
        }
    }
}
