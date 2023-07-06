using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deutsch_code
{
    internal class checker
    {
        public static bool dtoe(string ans, int idx)
        {
            if (getWord.getEWord(idx).ToLower() == ans.ToLower())
            {
                return true;
            }
            else { return false; }
        }
        public static bool etod(string ans, int idx)
        {
            if (getWord.getDWord(idx).ToLower() == ans.ToLower())
            {
                return true;
            }
            else { return false; }
        }
    }
}
