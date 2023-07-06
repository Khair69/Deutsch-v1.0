using deutsch_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deutsch_v1._0
{
    internal class Question
    {
        private int idx;
        private string dWord;
        private string eWord;
        private static string wPath;

        public void newQuestion()
        {
            String line;
            try
            {
                line = File.ReadLines(@"..\..\..\..\words\words.txt").Skip(idx - 1).Take(1).First();
                string[] wline = line.Split();
                dWord = wline[1];
                eWord = wline[2];
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public string getDWord() { return dWord; }
        public string getEWord() { return eWord; }
        public void setIdx(int idx) { this.idx = idx;}

        public bool dtoe(string ans)
        {
            if (ans.ToLower() == eWord.ToLower()) return true;
            else return false;
        }
        public bool etod(string ans) 
        {
            if (ans.ToLower() == dWord.ToLower()) return true;
            else return false;
        }

    }
}
