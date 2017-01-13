using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval_Insert
{
    ////    Given intervals[1, 3],[6, 9], insert and merge[2, 5] in as [1,5],[6,9].
    ////Example 2:
    ////Given[1, 2],[3,5],[6,7],[8,10],[12,16], insert and merge[4, 9] in as [1,2],[3,10],[12,16].
    ////This is because the new interval[4, 9] overlaps with[3, 5],[6,7],[8,10]


    class Program
    {
        public static List<Interval> insert(List<Interval> intervals, Interval newInterval)
        {
            List<Interval> result = new List<Interval>();
            ////int i = 0, size = intervals.Count;
            ////Console.WriteLine("=====+ Before insertion +=====");
            ////Console.WriteLine("");

            ////foreach (var item in intervals)
            ////{
            ////    Console.WriteLine("{0},{1}", item.start, item.end);
            ////}

            ////for (; i < size; ++i)
            ////{
            ////    if (intervals[i].start >= newInterval.start)
            ////    {
            ////        intervals.Insert(i, newInterval);
            ////        break;
            ////    }
            ////}
            ////if (i == size)
            ////    intervals.Add(newInterval);

            ////Interval pre = null;
            ////for (i = 0; i < intervals.Count; ++i)
            ////{
            ////    Interval cur = intervals[i];
            ////    if (pre == null || cur.start > pre.end)
            ////    {
            ////        result.Add(cur);
            ////        pre = cur;
            ////    }
            ////    else
            ////    {
            ////        pre.end = Math.Max(pre.end, cur.end);
            ////    }
            ////}


             int i = 0;
            for (; i < intervals.Count; ++i)
            {
                if (intervals[i].start >= newInterval.start)
                {
                    intervals.Insert(i, newInterval);
                    break;
                }
            }
             if (i == intervals.Count)
            intervals.Add(newInterval);

            Interval prev = null;
            foreach (var inter in intervals)
            {
                if (prev == null || inter.start > prev.end)
                {
                    result.Add(inter);
                    prev = inter;
                }
                else if (inter.end > prev.end)
                {
                    // Modify the element already in list
                    prev.end = inter.end;
                }
            }
            return result;
        }


        public class Interval 
        {
            public int start, end;
            public Interval(int start, int end)
            {
                this.start = start;
                this.end = end;
            }

           
        }
        static void Main(string[] args)
        {

            List<Interval> list = new List<Interval>();

            Interval a = new Interval(1, 3);
            Interval d = new Interval(15, 18);
            Interval c = new Interval(8, 10);
            
            Interval b = new Interval(2, 6);
          
            Interval e = new Interval(10, 14);
            list.Add(a);
            list.Add(d);
            list.Add(b);
            list.Add(c);
            
            //[1,3],[2,6],[8,10],[15,18]
            List<Interval> listt = insert(list,e);
            Console.WriteLine(" ");
            Console.WriteLine("=====+ After insertion +=====");
            Console.WriteLine(" ");
            foreach (var item in listt)
            {
                Console.WriteLine("{0},{1}", item.start, item.end);
            }
            Console.ReadLine();
        }
    }
}
