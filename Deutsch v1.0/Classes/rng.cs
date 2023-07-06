using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deutsch_code
{
    internal class rng
    {
        public static int[] rngBetween(int from ,int to)
        {
            int[] er = { -1 };
            if (from <=0 || to <= 0) return er;
            Random rnd = new Random();
            int size = to - from + 1;
            int[] rngs = new int[size];
            int rplc;
            for (int i =0; i < size; i++)
            {
                rplc = rnd.Next(from,to+1);
                while (rngs.Contains(rplc) == true)rplc = rnd.Next(from,to+1);
                rngs[i] = rplc;
            }
            return rngs;
        }
    }
}
