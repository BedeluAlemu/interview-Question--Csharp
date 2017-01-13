using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversString
{
    public class ReversStringText
    {
        public StringBuilder ReverseMethod(string st)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            
            for (int i = st.Length - 1; i >= 0; i--)
                {

                    if (!(Char.IsDigit(st[i])) && (st[i] != '-') && (st[i] != '+'))
                    {
                        if (sb2.Length != 0)
                        {
                            sb.Append(sb2);
                            sb.Append(st[i]);
                            sb2.Clear();
                        }
                        else
                        {
                            sb.Append(st[i]);
                        }
                    }
                    else if ((Char.IsDigit(st[i])))
                    {
                        sb2.Append(st[i]);
                    }
                    else if ((st[i] != '-') || (st[i] != '+'))
                    {
                        sb.Append(st[i]);
                        sb.Append(sb2);
                        sb2.Clear();

                    }
                    if ((sb2.Length != 0) && (i == 0))
                    {
                        sb.Append(sb2);
                        sb2.Clear();
                    }

                }
            
            return sb;
        }
    }
}
