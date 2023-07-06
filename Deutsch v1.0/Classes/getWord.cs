using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace deutsch_code
{
    internal class getWord
    {
        public static string getDWord(int idx)
        {
            String line;
            try
            {
                line = File.ReadLines(@"..\..\..\..\words\words.txt").Skip(idx-1).Take(1).First();
                string[] wline = line.Split();
                return wline[1];
            }
            catch (Exception e)
            {
                return "Exception: " + e.Message;
            }
        }
        public static string getEWord(int idx)
        {
            String line;
            try
            {
                line = File.ReadLines(@"..\..\..\..\words\words.txt").Skip(idx - 1).Take(1).First();
                string[] wline = line.Split();
                return wline[2];
            }
            catch (Exception e)
            {
                return "Exception: " + e.Message;
            }
        }
    }
}
