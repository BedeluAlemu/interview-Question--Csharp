using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZagConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "PAY PAL IS HIRING ME";
            String x = convert(s, 3);
            Console.WriteLine(x);
            Console.ReadLine();

        }

        
            public static String convert(String s, int numRows)
            {
                int len = s.Length ;
                if (len == 0 || numRows == 0) return "";
                if (numRows == 1) return s;

                StringBuilder[] resRows = new StringBuilder[numRows];

                for (int i = 0; i < numRows; i++)
                {
                    resRows[i] = new StringBuilder();
                }

                int rowIdx = 0;
                int step = 1;
                for (int i = 0; i < len; i++)
                {
                    resRows[rowIdx].Append(s[i]);
                    if ((step == 1 && rowIdx == numRows - 1) || (step == -1 && rowIdx == 0))
                    {
                        step = -1 * step;
                    }
                    rowIdx += step;
                }

                StringBuilder sb = new StringBuilder();
                  sb = resRows[0];
                for (int i = 1; i < numRows; i++)
                {
                    sb.Append(resRows[i]);
                }

                return sb.ToString();
            }
         



        //public static StringBuilder convert(string s, int nRows)
        //{
        //    // Start typing your C/C++ solution below
        //    // DO NOT write int main() function    
        //    if (nRows <= 1) return new StringBuilder( s );
        //    //string ret;
        //    StringBuilder ret = new StringBuilder();
        //    int zigsize = 2 * nRows - 2;

        //    for (int i = 0; i < nRows; ++i)
        //    {
        //        for (int K = i; ; K += zigsize)
        //        {
        //            if (K >= s.Length)
        //                break;
        //            ret.Append(s[K]);
        //            if (i > 0 && i < nRows - 1)
        //            {
        //                //middle need add ziggggging char
        //                int ti = K + zigsize - 2 * i;
        //                if (ti < s.Length)
        //                    ret.Append( s[ti]);
        //            }
        //        }
        //    }
        //    return ret;
        //}


        //public static String convert(String s, int numRows)
        //{
             
        //    if (s.Length <= numRows || numRows == 1)
        //    {
        //        return s;
        //    }
            
        //    int row = numRows;
        //    int col1 = s.Length / (2 * (numRows - 1));
        //    int col2 = s.Length % (2 * (numRows - 1));
        //    int col = 0;

        //    if (col2 <= numRows)
        //    {
        //        col = (numRows - 1) * col1 + 1;
        //    }
        //    else
        //    {
        //        col = (numRows - 1) * col1 + 1 + col2 - numRows;
        //    }

        //    char[,] arr = new char[row,col];
        //    int count = 2 * (numRows - 1);
        //    for (int k = 0; k < s.Length; k++)
        //    {
        //         //组号
        //        int group = k / count;
                 
        //        int rankInGroup = k % count;
        //        int r = 0;
        //        int c = 0;
                 
        //        if (rankInGroup <= numRows - 1)
        //        {
        //            r = rankInGroup;
        //            c = (numRows - 1) * group;
        //        }
        //        else
        //        {
        //            c = (numRows - 1) * group + 1 + rankInGroup - numRows;
        //            r = 2 * numRows - rankInGroup - 2;
        //        }
        //        //System.out.println("r="+r+";c="+c);
        //        arr[r,c] = s[k];
        //    }

        //    StringBuilder result = new StringBuilder();
        //    for (int i1 = 0; i1 < row; i1++)
        //    {
        //        for (int j1 = 0; j1 < col; j1++)
        //        {
        //            if (arr[i1,j1] != 0)
        //            {
        //                result.Append(arr[i1,j1]);
        //            }
        //        }
        //    }
        //    return result.ToString();
        //}





















        ////public static String convert(String s, int nRows)
        ////{

        ////    int length = s.Length;
        ////    if (nRows == 0 || nRows == 1 || nRows >= length)
        ////        return s;

        ////    char[] result = new char[length];
        ////    int span = 2 * nRows - 2;
        ////    int index = 0;
        ////    for (int r = 0; r < nRows; r++)
        ////    {
        ////        int start = r;
        ////        int innerSpan = span - r * 2;
        ////        while (start < length)
        ////        {
        ////            result[index++] = s[start];
        ////            if (r != 0 && r != nRows - 1 && start + innerSpan < length)
        ////                result[index++] = s[start + innerSpan];

        ////            start += span;
        ////        }
        ////    }
        ////    return result.ToString();
        ////}

        ////static void Main(string[] args)
        ////{
        ////    string s = convert("123456789",5);
        ////    Console.WriteLine(s);
        ////    Console.ReadLine();
        ////}

    }
}
