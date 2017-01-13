using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval
{
    public class Interval:IComparable<Interval>
    {
        public int start, end;
        public Interval(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        // overide CompareTo method
        public int CompareTo(Interval other)
        {
          return  this.start.CompareTo(other.start);
        }
    }

    public class Solution
    {

        public static List<Interval> merge(List<Interval> intervals)
        {
            intervals.Sort();

            foreach (var item in intervals)
            {
                Console.WriteLine("{0},{1}", item.start, item.end);
            }

            List<Interval> ret = new List<Interval>();


             Interval prev = null;
            foreach (var inter in intervals)
            {
                if (prev == null || inter.start > prev.end)
                {
                    ret.Add(inter);
                    prev = inter;
                }
                else if (inter.end > prev.end)
                {
                    // Modify the element already in list
                    prev.end = inter.end;
                }
            }
           
        return ret;
    }
 
        static void Main(string[] args)
        {
           // List<Interval> listt = new List<Interval>();

            List<Interval> list = new List<Interval>();
           
            Interval a = new Interval(1, 3);
            Interval b = new Interval(2, 6);
            Interval c = new Interval(8, 10);
            Interval d = new Interval(15, 18);
            list.Add(a);
            list.Add(b);
            list.Add(c);
            list.Add(d);
          //[1,3],[2,6],[8,10],[15,18]
        List<Interval> listt =  merge(list);



            foreach (var item in listt)
            {
                Console.WriteLine("{0},{1}", item.start,item.end);
            }
            Console.ReadLine();
        }
    }
}
