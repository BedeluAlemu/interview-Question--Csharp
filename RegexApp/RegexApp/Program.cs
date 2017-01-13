using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexApp
{
    //IsMatch(string) - Returns True or False
    //Match(string) - Returns 0 or 1 Match object
    //Matches(string) - Returns a MatchCollection object containing zero or more Match objects
    //Replace(pattern, string) - Replaces all instances of the regular expression pattern with the string
    //Split(string, pattern) - Takes the pattern as a delimiter and returns an array of strings.
    //http://www.mikesdotnetting.com/article/50/c-regular-expressions-the-basics
    //http://files.meetup.com/120908/Regexp%20Quick%20Reference.pdf
    //http://www.c-sharpcorner.com/uploadfile/955025/regular-expression-in-c-sharp/

    class Program
    {
        static void Main(string[] args)
        {
            string input = "A12";
            string pattern = @"[a-zA-Z]\d";

            
            Regex regex = new Regex(pattern);
            
            //1.Match(string)
            Match m = regex.Match(input);
            
            //2.IsMatch(string)
            if (regex.IsMatch(input))
            {
                Console.Write(m.Value + " ");
            }


            //////////////////////////////////////////////////////
            //3.Matches(string)
            string input2 = "A12 B34 C56 D78";
                    pattern = @"\d";



             Regex regexObj = new Regex(pattern);

             
             MatchCollection mc = regexObj.Matches(input2);

            foreach (Match mt in mc)
            {
                Console.WriteLine(mt.ToString() + " ");
            }
            Console.Write(mc.Count.ToString() + " ");

            ///////////////////////////////////////////////////////
            //4.Replace(string,replace)
            string input3 = @"A12 B34 C56 D78 E12 F34 G56 H78";
                  pattern = @"[a-zA-Z]\d";

            Regex Obj = new Regex(pattern);

            
            string newString = Obj.Replace(input3, "XX");
            Console.WriteLine(newString);


            /////////////////////////////////////////////////
            //5.Split(string) 

            string input4 = "AB1 DE2 FG3 HI4 JK5 LM6 NO7 PQ8 RS9";
            string pattern1 = @"[^\d]";


            Regex re1 = new Regex(pattern1);
          string s =   re1.Replace(input4, string.Empty);
            Console.WriteLine(s);
            //  Match m1 =   re1.Match(input4);
            

          //  if (m1.Success)
         //   {
         //       Console.WriteLine(m1.Value);
         //   }

            Regex re = new Regex(@"\d");
            string[] parts = re.Split(input4);
            Console.WriteLine("");
            foreach (string part in parts)
            {
                Console.WriteLine(part + "<br />");
            }


            Console.ReadLine();
        }
    }
}
